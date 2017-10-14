# Simple Factory Pattern - 簡單工廠模式


將演算法的Class各自獨立，且共同繼承一個Abstract Class，並透過Factory Pattern封裝建立實體的程式碼。
未來新增新的演算法Class，只需要繼承Abstract Class並實作各自的演算方法，並修改Factory增加新的建立實體程式即可。

在這個例子中，將加、減、乘、除運算各自獨立成`OperationAdd`、`OperationSub`、`OperationMul`、`OperationDiv`，並共同繼承`Operation`，
且將`GetResult`方法設為`Virtual`，交由繼承的子類別實作，再用`OperationSimpleFactory`封裝建立實體的方法，將變化部分封裝在同一個地方，
將來要擴充只需要修改`OperationFactory`與增加新的演算法Class並繼承`Operation`，完全不會異動到其他演算法Class。


# 類別圖

![狀態模式](https://github.com/BryanYu/DesignPatternPractice/blob/master/SimpleFactory/ClassDiagram1.png)

