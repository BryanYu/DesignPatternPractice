# Command Pattern - 命令模式

定義：將一個請求封裝成物件，可以用不同的請求對客戶進行參數化；對請求佇列或記錄日誌，以及支援可取消的操作

命令模式可以容易地設計出一個命令佇列，也可以將命令記入日誌，接收的一方可以選擇否決命令、取消或重作，而新加入的具體命令類別不會影響其他類別的程式碼，可以方便擴充。


# 類別圖

![命令模式](https://github.com/BryanYu/DesignPatternPractice/blob/master/Command/ClassDiagram1.png)


