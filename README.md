# Controll-GUI
For EE501 project
####可於水中作業之遙控水陸兩用多功能載具 使用者介面
Author :  Shiuan Chi Huang
         1102104112@gm.kuas.edu.tw

##PartA. Stable Version History
###v0.1.0  on 2016/02/28 02:22
 - 可選擇Serial Port,Baudrate,接收資料並顯示在Message的RichTextbox中.
 - 可獨立分析出資料字串，方便下一版本解析，字串顯示在LableNOW中.
 - 資料格式為 "$資料內容標題;資料內容1,資料內容2,資料內容3...,$~"
 
###v1.0.0  on 2016/10/17 08:58
 - 可分析 GPS 字串資料，並將資料鎖定為之經緯度換算後顯示出來，並移動地圖畫面。($GPRMC...)
 - 可解析車體內、車體外、浮標溫度資料並顯示於TextBox內，再將資料每秒更新顯示於折線圖表中。($BUOY_TEMP;$VEHI_TEMPOUT;$VEHI_TEMPIN)
 - 可解析氣壓資訊，換算後，顯示於Label上，並換算出所在位置之高度。($BUOY_PRES)
 - 可設定、擷取影像資訊並顯示。
 - 可對載具下達命令(將命令字元以Srial Port傳送到UI Driver處理器)使其動作。
 - 地圖部分可透過放大縮小按鈕調整縮放程度。
 - 增加字串錯誤計數器，每次發生字串解析數值例外時便會累計計數，方便除錯。
 - 針對各種意外操作做出提示，防止例外誤動作。
 - 新增連結狀態欄(Status Bar)，透過計時器定期檢查或字串解析，可判斷並表示與載具間的連接狀態。($DRIVER CONNECTED,1$~;$BUOY_CONNECTED$~;$VEHI_CONNECTED$~)
 - 新增方位腳解析程序，可解析資料字串中的浮標與載具面向方位的角度資料，並判斷方位顯示於地圖旁。($BUOY_FDEG:;$VEHI_FDEG:)
 - 預留電壓(電流)解析程序。($BUOY_CUR:)

##PartB. TODO
 - [ ] Analysis the DATAString and Show the DATA of gravity, Magnetic Field, Groy Information 
 - [x] Analysis Presure,Temperature Data from datastring       //before 1.0.0
 - [x] Analyse GPS Data and show on map                        //Ver 1.0.0
 - [x] Transit Data to PIC                                     //before 1.0.0
 - [x] Control Motor via this project                          //before 1.0.0
 - [x] Transit Data Out                                        //before 0.1.0
 - [x] UART Config Setting Enable                              //Ver 0.1.0
 - [x] Receive Data From PIC                                   //Ver 0.1.0
 - [ ] Add Map style chosen button
 
##PartC. BUG to Fix
###Ver 0.1.0
 - [x] Sometimes the DATAString (LableNOW) will have 2 DATA
 - [x] Sometimes the ADXL345's DATA will be abnormal           //and we don't use ADXL345 anymore

###Ver 1.0.0
 - [ ] Sometime will happen the Unexpected error but can't figure out where the fault is.(Seems to be in video capture shown process)
 - [ ] When disconnect the Driver and reconnect it, the X-Axis Value don't reset in Temperature sheet.
 - [ ] After the App run for a while , the process speed will be slow down and hard to control.
 - [ ] String Error MessageBox will show on when String Error happened, but it usually get a lot of String Error when it happened and will get A LOT of Messagebox...
 
