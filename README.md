skipman
=======
# 何をするアプリ？
skipmanは、SONY製ウォークマンNW-ZX1内の、複数枚アルバムの曲順を自動訂正するプログラムです。

# 具体的には？ 
NW-ZX1では、2枚組などの複数枚アルバムを再生するとき、1枚目のトラック1、2枚目のトラック1、1枚目のトラック2、2枚目のトラック2・・・という不自然な曲順で再生される仕様になっています。  
skipmanは、アルバム内でのトラック番号を一意に書き換えることで、1枚目のトラック1、1枚目のトラック2、・・・2枚目のトラック1、2枚目のトラック2・・・という自然な曲順で再生されるようにします。  

# 使用方法
1. 実行前に音楽ファイルのバックアップを取っておくことをおすすめします。
2. [release](http://github.com/tacores/skipman/releases)からZIPファイルをダウンロードして解凍します。
3. WindowsPCに、NW-ZX1をUSBストレージONの状態で接続します。
4. skipman.exeをダブルクリックして起動します。
5. 「スキャン」ボタンを押します。スキャンには数分以上の時間がかかるので気長に待ってください。
6. 複数枚アルバムと思われるアルバムが一覧表示されます。アルバムを選択すると、下の欄に曲が表示されます。
7. 「選択したアルバムを再採番」または「左の全アルバムを再採番」ボタンを押します。  
![画面キャプチャ](https://raw.githubusercontent.com/tacores/skipman/master/images/capture.png)

# 環境
## 実行環境
実行環境はWindows（.NET Framework4）のみです。  
ただし、MacでNW-ZX1に転送したアルバムに対しても使えます。
## 開発環境
Visual Studio 2010以降、.NET Framework4。  
参照設定で[TagLib#](http://github.com/mono/taglib-sharp)の「taglib-sharp.dll」の参照を追加する必要があります。  
ユニットテストの実行には、「NUnit」と「NSubstitute」の参照を追加する必要があります。

# ライセンス
skipmanはMITライセンスです。同梱の「LICENSE」を参照してください。  
This software is released under the MIT License, see LICENSE.

# 使用ライブラリ
タグ情報の読み書きに[TagLib#](http://github.com/mono/taglib-sharp)を使用しています。  
「TagLib#」のライセンスはLGPL2.1です。リリースに同梱の「COPYING.txt」を参照してください。  
This software links dynamically with [TagLib#](http://github.com/mono/taglib-sharp) which is released under the LGPS2.1. See COPYING.txt which is bundled in release zip.