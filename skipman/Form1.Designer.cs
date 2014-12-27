namespace skipman
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSelect = new System.Windows.Forms.Button();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.labelFolder = new System.Windows.Forms.Label();
            this.buttonAnalyze = new System.Windows.Forms.Button();
            this.buttonAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewDetail = new System.Windows.Forms.DataGridView();
            this.Disc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Track = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewTrack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBarScan = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(604, 60);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(164, 42);
            this.buttonSelect.TabIndex = 0;
            this.buttonSelect.Text = "選択したアルバムを訂正";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 12;
            this.listBoxAlbums.Location = new System.Drawing.Point(12, 60);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(586, 160);
            this.listBoxAlbums.TabIndex = 3;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // labelFolder
            // 
            this.labelFolder.AutoSize = true;
            this.labelFolder.Location = new System.Drawing.Point(96, 17);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(35, 12);
            this.labelFolder.TabIndex = 5;
            this.labelFolder.Text = "label1";
            // 
            // buttonAnalyze
            // 
            this.buttonAnalyze.Location = new System.Drawing.Point(15, 12);
            this.buttonAnalyze.Name = "buttonAnalyze";
            this.buttonAnalyze.Size = new System.Drawing.Size(75, 23);
            this.buttonAnalyze.TabIndex = 6;
            this.buttonAnalyze.Text = "スキャン";
            this.buttonAnalyze.UseVisualStyleBackColor = true;
            this.buttonAnalyze.Click += new System.EventHandler(this.buttonAnalyze_Click);
            // 
            // buttonAll
            // 
            this.buttonAll.Location = new System.Drawing.Point(604, 108);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(164, 42);
            this.buttonAll.TabIndex = 7;
            this.buttonAll.Text = "全てのアルバムを訂正";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "曲順の訂正が必要と思われるアルバム";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "アルバム詳細";
            // 
            // dataGridViewDetail
            // 
            this.dataGridViewDetail.AllowUserToAddRows = false;
            this.dataGridViewDetail.AllowUserToDeleteRows = false;
            this.dataGridViewDetail.AllowUserToResizeRows = false;
            this.dataGridViewDetail.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Disc,
            this.Track,
            this.NewTrack,
            this.Title,
            this.Artist});
            this.dataGridViewDetail.Location = new System.Drawing.Point(12, 247);
            this.dataGridViewDetail.MultiSelect = false;
            this.dataGridViewDetail.Name = "dataGridViewDetail";
            this.dataGridViewDetail.ReadOnly = true;
            this.dataGridViewDetail.RowTemplate.Height = 21;
            this.dataGridViewDetail.Size = new System.Drawing.Size(756, 178);
            this.dataGridViewDetail.TabIndex = 10;
            this.dataGridViewDetail.TabStop = false;
            // 
            // Disc
            // 
            this.Disc.HeaderText = "ディスク";
            this.Disc.Name = "Disc";
            this.Disc.ReadOnly = true;
            this.Disc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Disc.Width = 50;
            // 
            // Track
            // 
            this.Track.HeaderText = "トラック";
            this.Track.Name = "Track";
            this.Track.ReadOnly = true;
            this.Track.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Track.Width = 50;
            // 
            // NewTrack
            // 
            this.NewTrack.HeaderText = "変更後トラック";
            this.NewTrack.Name = "NewTrack";
            this.NewTrack.ReadOnly = true;
            this.NewTrack.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NewTrack.Width = 50;
            // 
            // Title
            // 
            this.Title.HeaderText = "タイトル";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Title.Width = 300;
            // 
            // Artist
            // 
            this.Artist.HeaderText = "アーティスト";
            this.Artist.Name = "Artist";
            this.Artist.ReadOnly = true;
            this.Artist.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Artist.Width = 250;
            // 
            // progressBarScan
            // 
            this.progressBarScan.Location = new System.Drawing.Point(538, 12);
            this.progressBarScan.Name = "progressBarScan";
            this.progressBarScan.Size = new System.Drawing.Size(230, 23);
            this.progressBarScan.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarScan.TabIndex = 11;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(547, 38);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(17, 12);
            this.labelProgress.TabIndex = 12;
            this.labelProgress.Text = "   ";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(604, 190);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(164, 30);
            this.buttonRemove.TabIndex = 13;
            this.buttonRemove.Text = "リストから除外";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 437);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.progressBarScan);
            this.Controls.Add(this.dataGridViewDetail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.buttonAnalyze);
            this.Controls.Add(this.labelFolder);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.buttonSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "skipman";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.Button buttonAnalyze;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewDetail;
        private System.Windows.Forms.ProgressBar progressBarScan;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Track;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewTrack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.Button buttonRemove;
    }
}

