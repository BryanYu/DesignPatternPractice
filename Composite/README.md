# Composite Pattern - 組合模式

定義：將物件組合成樹狀結構表示「部分-整體」的層次結構。組合模式使得用戶對單個物件和組合物件的使用具有一致性。

組合模式其實就是樹狀結構，在葉節點中，還是有了`Add`與`Remove`方法，對葉節點來說，不需要實作`Add`與`Remove`方法，因為已經到最底層沒有下層了，但就使用的一致性來說，
根節點與葉節點的行為保持一致，使用上來說較為方便。


# 類別圖

![組合模式](https://github.com/BryanYu/DesignPatternPractice/blob/master/Composite/ClassDiagram1.png)


