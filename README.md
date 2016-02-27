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

##PartB. TODO
 - [ ] Analysis the DATAString and Show the DATA of gravity, Magnetic Field, Groy Information 
 - [ ] Transit Data to PIC
 - [ ] Control Motor via this project
 - [x] Transit Data Out             //before 0.1.0
 - [x] UART Config Setting Enable   //Ver 0.1.0
 - [x] Receive Data From PIC        //Ver 0.1.0
 
##PartC. BUG to Fix
###Ver 0.1.0
 - [ ] Sometimes the DATAString (LableNOW) will have 2 DATA
 - [ ] Sometimes the ADXL345's DATA will be abnormal
