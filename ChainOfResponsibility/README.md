# ChainOfResponsiblity Pattern - 責任鏈模式

定義：使多個物件都有機會處理請求，避免請求的發送者與接受者之間耦合。將這個物件連成一條鏈，並沿著這條鏈發送請求，直到有一個物件處理它為止。

要注意的是，一個請求可能到了鏈的後端都還沒有機會被處理，或者是因為配置不正確而未被處理，所以責任鏈要使用前需考量全面的情況

# 類別圖

![責任鏈模式](https://github.com/BryanYu/DesignPatternPractice/blob/master/ChainOfResponsibility/ClassDiagram1.png)


