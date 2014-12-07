skipman
=======
# 何をするアプリ？
skipmanは、SONY製ウォークマンNW-ZX1内の、複数枚アルバムの曲順を自動訂正するプログラムです。

# 具体的には？ 
NW-ZX1では、複数枚アルバムを再生するとき、1枚目のトラック1、2枚目のトラック1、1枚目のトラック2、2枚目のトラック2・・・という不自然な順序で再生される仕様になっています。  
アルバム内でのトラック番号を一意になるよう書き換えることによって、1枚目のトラック1、1枚目のトラック2、・・・2枚目のトラック1、2枚目のトラック2・・・という自然な曲順で再生されるようにします。  
なお、このアプリは「アルバムのタイトル名」の一致で同一のアルバムと判断します。異なるアーティストで同名のアルバムが入っている場合、かえって不自然な結果になる可能性があります。

# 使用方法
1. [release](http://github.com/tacores/skipman/releases)からバイナリをダウンロードします。
2. WindowsPCに、NW-ZX1をUSBストレージONの状態で接続します。
3. skipman.exeをダブルクリックして起動します。
4. 「スキャン」ボタンを押します。スキャンには数分以上の時間がかかるので気長に待ってください。
5. 複数枚アルバムと思われるアルバムが一覧表示されます。アルバムを選択すると、下の欄に曲が表示されます。
6. 「選択したアルバムを再採番」または「左の全アルバムを再採番」ボタンを押します。

# 環境
## 実行環境
実行環境はWindows（.NET Framework4）のみです。  
ただし、MacでNW-ZX1に転送したアルバムに対しても使えます。
## 開発環境
Visual Studio 2010以降、.NET Framework4。  
参照設定で[TagLib#](http://github.com/mono/taglib-sharp)の「taglib-sharp.dll」の参照を追加する必要があります。

# ライセンス
skipmanはMITライセンスです。同梱の「LICENSE」を参照してください。  
This software is released under the MIT License, see LICENSE.

# 使用ライブラリ
タグ情報の読み書きに[TagLib#](http://github.com/mono/taglib-sharp)を使用しています。  
「TagLib#」のライセンスはLGPL2.1です。リリースに同梱の「COPYING.txt」を参照してください。  
This software links dynamically with [TagLib#](http://github.com/mono/taglib-sharp) which is released under the LGPS2.1. See COPYING.txt which is bundled in release zip.