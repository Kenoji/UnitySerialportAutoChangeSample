# UnitySerialportAutoChangeSample
## これはどんなもの？
  Windows&Unityでシリアル通信を行う際に、Unity上からデバイス名で検索をしてポート番号を割り当ててくれるものです。
## どうやっているの?
  ManagementClass("Win32_PnPEntity")を通常のC#上から叩くコンソールアプリケーションを作成し、そのアプリケーションをUnity上から呼び出すことで実現しています、そのため実行の際にはGetComDevices.exeがUnityの実行ファイルと同じディレクトリ(エディタ実行時はプロジェクトフォルダ直下)に存在しなければいけません。
## 使い方は？
  SerialHandler,SearchComを適当なオブジェクトに貼り付け、SearchComに接続したいデバイスの名前(デバイスマネージャー上の名前)を入力してください、実行時に自動的にSerialHanderに接続先デバイスのCOMポート番号が入ります。
