﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace skipman
{
    /// <summary>
    /// メインダイアログ
    /// </summary>
    public partial class Form1 : Form, ProgressListener
    {
        private Dictionary<string, Album> albums;
        private List<string> removedAlbums;
        private FileSystem fileSystem;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            removedAlbums = new List<string>();
            fileSystem = new FileSystemImpl();

            searchWalkmanDrive();
        }

        /// <summary>
        /// walkmanドライブ検索
        /// </summary>
        private void searchWalkmanDrive()
        {
            try
            {
                labelFolder.Text = fileSystem.getWalkmanDriveName() + "Music";
            }
            catch (Exception)
            {
                MessageBox.Show("WALKMANドライブが見つかりませんでした。\nUSBストレージがONになっているか確認してください。");
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// スキャンボタン押下ハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnalyze_Click(object sender, EventArgs e)
        {
            Thread worker = new Thread(this.scanMusicFolder);
            worker.Start();
        }

        /// <summary>
        /// Musicフォルダスキャン
        /// </summary>
        private void scanMusicFolder()
        {
            string[] files = fileSystem.getAllFileNames(labelFolder.Text);
            albums = new AlbumDictionaryCreatorImpl(this).create(files);

            updateAlbumList();
        }

        delegate void delegateVoidVoid();
        /// <summary>
        /// アルバム一覧リスト更新
        /// </summary>
        private void updateAlbumList()
        {
            if (this.InvokeRequired)
            {
                delegateVoidVoid dlg = new delegateVoidVoid(updateAlbumList);
                this.Invoke(dlg);
                return;
            }

            listBoxAlbums.Items.Clear();
            foreach (KeyValuePair<string, Album> pair in albums)
            {
                if (pair.Value.needCorrect)
                {
                    listBoxAlbums.Items.Add(pair.Value.Title);
                }
            }
            if (listBoxAlbums.Items.Count == 0)
            {
                MessageBox.Show("トラック番号が重複しているアルバムは見つかりませんでした。");
            }
        }

        /// <summary>
        /// アルバム一覧リストの項目選択ハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            int newTrack = 1;
            for (uint i = 1; album != null && i <= album.DiscCount; ++i)
            {
                Disc disc = album.getDisc(i);
                for (uint j = 1; disc != null && j <= disc.TrackCount; ++j)
                {
                    Track track = disc.getTrack(j);
                    dataGridViewDetail.Rows.Add(disc.DiskNum, track.TrackNum, newTrack++, track.Title, track.Artist);
                }
            }
        }

        /// <summary>
        /// 「選択中のアルバムを再採番」ボタン押下ハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            string albumName = (string)listBoxAlbums.SelectedItem;
            overwriteAlbum(albumName);
            removeAlbumList();
            MessageBox.Show("完了しました");
        }

        /// <summary>
        /// 「左の全アルバムを再採番」ボタン押下ハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAll_Click(object sender, EventArgs e)
        {
            foreach (string albumName in listBoxAlbums.Items)
            {
                overwriteAlbum(albumName);
            }
            removeAlbumList();
            MessageBox.Show("全て完了しました");
        }

        /// <summary>
        /// アルバム上書き
        /// </summary>
        /// <param name="albumName">上書きするアルバム名</param>
        private void overwriteAlbum(string albumName)
        {
            TrackResetter resetter = new TrackResetter();
            try
            {
                Album album = albums[albumName];
                resetter.reset(album);
                removedAlbums.Add(albumName);
            }
            catch (Exception )
            {
                MessageBox.Show(albumName + " を処理中にエラーが発生しました");
                throw;
            }
        }

        /// <summary>
        /// 再採番済みのアルバムをアルバム一覧から削除
        /// </summary>
        private void removeAlbumList()
        {
            foreach (string name in removedAlbums)
            {
                listBoxAlbums.Items.Remove(name);
            }
            removedAlbums.Clear();
        }

        delegate void delegateNotifyProgress(int all, int done);
        /// <summary>
        /// スキャン進捗通知
        /// </summary>
        /// <param name="all"></param>
        /// <param name="done"></param>
        public void notifyProgress(int all, int done)
        {
            if(this.InvokeRequired)
            {
                delegateNotifyProgress dlg = new delegateNotifyProgress(notifyProgress);
                this.Invoke(dlg, all, done);
                return;
            }
            updateProgressBar(all, done);
            updateProgressLabel(all, done);
        }

        private void updateProgressBar(int all, int done)
        {
            progressBarScan.Minimum = 0;
            progressBarScan.Maximum = all;
            progressBarScan.Value = done;
            progressBarScan.Update();
        }

        private void updateProgressLabel(int all, int done)
        {
            labelProgress.Text = "(" + done + "/" + all + ")";
            labelProgress.Update();
        }
    }
}
