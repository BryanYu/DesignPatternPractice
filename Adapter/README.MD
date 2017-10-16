# Adapter Pattern - 轉接器模式

定義：將一個類別的介面轉換成用戶端希望的另一個介面，`Adapter`模式讓那些原本介面不相容的類別變得可以一起使用。

當系統的資料與行為都正確，但介面不相符時，可以考慮使用`Adapter`模式，目的是使控制範圍外的一個原有物件跟某個介面搭配。
在設計前期，如果有遇到這樣的情況，`優先考慮`進行重構，讓介面保持一致，當雙方系統變成不易修改時才考慮使用`Adapter`

# 類別圖

![轉接器模式](https://github.com/BryanYu/DesignPatternPractice/blob/master/Adapter/ClassDiagram1.png)


