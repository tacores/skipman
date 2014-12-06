using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace skipman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            removedAlbums = new List<string>();
            searchWalkmanDrive();
        }

        private void searchWalkmanDrive()
        {
            //現在のコンピュータの論理ドライブを取得
            System.IO.DriveInfo[] drives = System.IO.DriveInfo.GetDrives();
            foreach (System.IO.DriveInfo d in drives)
            {
                try
                {
                    if(d.VolumeLabel == "WALKMAN")
                    {
                        label1.Text = d.Name + "Music";
                        return;
                    }
                }
                catch (Exception)
                {
                }
            }
            MessageBox.Show("WALKMANドライブが見つかりませんでした。\nUSBストレージがONになっているか確認してください。");
            Environment.Exit(0);
        }

        private Dictionary<string, Album> albums;

        private void scanMusicFolder()
        {
            albums = new Dictionary<string,Album>();
            string[] files = System.IO.Directory.GetFiles(label1.Text, "*", System.IO.SearchOption.AllDirectories);
            foreach (string file in files)
            {
                try
                {
                    using (TagLib.File tagFile = TagLib.File.Create(file))
                    {
                        if (tagFile.Tag.Disc == 0 || tagFile.Tag.DiscCount == 0 || tagFile.Tag.Track == 0 || tagFile.Tag.TrackCount == 0)
                        {
                            continue;
                        }

                        Album al;
                        if (!albums.ContainsKey(tagFile.Tag.Album))
                        {
                            albums[tagFile.Tag.Album] = new Album(tagFile.Tag.Album, tagFile.Tag.DiscCount);
                        }

                        al = albums[tagFile.Tag.Album];
                        al.addTrack(tagFile.Tag.Disc, tagFile.Tag.Track, tagFile.Tag.TrackCount, tagFile.Tag.Title, file);
                    }
                }
                catch (TagLib.CorruptFileException)
                {
                    continue;
                }
                catch (Exception)
                {
                    continue;
                }
            }

            listBoxAlbums.Items.Clear();
            foreach (KeyValuePair<string, Album> pair in albums)
            {
                if(pair.Value.needHosei)
                {
                    listBoxAlbums.Items.Add(pair.Value.title);
                }
            }
            if (listBoxAlbums.Items.Count == 0)
            {
                MessageBox.Show("トラック番号が重複しているアルバムは見つかりませんでした。");
            }
        }

        private void buttonAnalyze_Click(object sender, EventArgs e)
        {
            scanMusicFolder();
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewDetail.Rows.Clear();

            string albumName = (string)listBoxAlbums.SelectedItem;
            if (albumName == null)
            {
                dataGridViewDetail.Rows.Clear();
                return;
            }
            Album album = albums[albumName];

            for (uint i = 0; album != null && i < album.discCount; ++i)
            {
                Disc disc = album.getDisc(i);
                for (uint j = 0; disc != null && j < disc.trackCount; ++j)
                {
                    Track track = disc.getTrack(j);
                    dataGridViewDetail.Rows.Add(disc.disk, track.oldTrackNum, track.name);
                }
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            string albumName = (string)listBoxAlbums.SelectedItem;
            overwriteAlbum(albumName);
            removeAlbumList();
            MessageBox.Show("完了しました");
        }

        private void overwriteAlbum(string albumName)
        {
            try
            {
                Album album = albums[albumName];
                uint newTrack = 1;

                for (uint i = 0; album != null && i < album.discCount; ++i)
                {
                    Disc disc = album.getDisc(i);
                    for (uint j = 0; disc != null && j < disc.trackCount; ++j)
                    {
                        Track track = disc.getTrack(j);
                        using (TagLib.File tagFile = TagLib.File.Create(track.path))
                        {
                            tagFile.Tag.Track = newTrack++;
                            tagFile.Save();
                        }
                    }
                }
                removedAlbums.Add(albumName);
            }
            catch (Exception e)
            {
                MessageBox.Show(albumName + " を処理中にエラーが発生しました");
                throw;
            }
        }

        private List<string> removedAlbums;

        private void buttonAll_Click(object sender, EventArgs e)
        {
            foreach (string albumName in listBoxAlbums.Items)
            {
                overwriteAlbum(albumName);
            }
            removeAlbumList();
            MessageBox.Show("全て完了しました");
        }

        private void removeAlbumList()
        {
            foreach (string name in removedAlbums)
            {
                listBoxAlbums.Items.Remove(name);
            }
            removedAlbums.Clear();
        }
    }
}
