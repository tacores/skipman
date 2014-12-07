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
            fileSystem = new FileSystemImpl();

            searchWalkmanDrive();
        }
        private FileSystem fileSystem;

        private void searchWalkmanDrive()
        {
            try
            {
                label1.Text = fileSystem.getWalkmanDriveName() + "Music";
            }
            catch (Exception)
            {
                MessageBox.Show("WALKMANドライブが見つかりませんでした。\nUSBストレージがONになっているか確認してください。");
                Environment.Exit(0);
            }
        }

        private Dictionary<string, Album> albums;

        private void scanMusicFolder()
        {
            AlbumDictionaryCreator creator = new AlbumDictionaryCreatorImpl();

            string[] files = fileSystem.getAllFileNames(label1.Text);
            albums = creator.create(files);

            listBoxAlbums.Items.Clear();
            foreach (KeyValuePair<string, Album> pair in albums)
            {
                if(pair.Value.needCorrect)
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

            for (uint i = 1; album != null && i <= album.discCount; ++i)
            {
                Disc disc = album.getDisc(i);
                for (uint j = 1; disc != null && j <= disc.trackCount; ++j)
                {
                    Track track = disc.getTrack(j);
                    dataGridViewDetail.Rows.Add(disc.disk, track.track, track.name);
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
            TrackResetter resetter = new TrackResetter();
            try
            {
                Album album = albums[albumName];
                resetter.reset(album);
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
