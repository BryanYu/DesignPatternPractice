# Strategy Pattern - 策略模式

定義：定義演算法家族，分別封裝，讓他們之間可以互相替換，此模式讓演算法的變化，不會影響到使用演算法的用戶端

在這個例子中，有三個具體策略，正常收費`CashNormal`、滿額送`CashReturn`、打折收費`CashRebate`，繼承同一個抽象類別`CashSuper`與實作`AcceptCash`方法，
並封裝至`CashContext`類別中，Factory建立`CashSuper`實體的程式進一步放至`CashContext`，用戶端在使用時，只需對`CashContext`類別操作，不需要知道內部的實作
，降低用戶端程式對其他類別耦合。

# 類別圖

![策略模式](https://github.com/BryanYu/DesignPatternPractice/blob/master/Strategy/ClassDiagram.png)


