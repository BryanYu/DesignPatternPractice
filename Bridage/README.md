# Bridage Pattern - 橋接模式

定義：將抽象的部分與實作部分分離，使他們都可以獨立的變化

## 合成與聚合原則
* 合成(Composition)：`強`的擁有關係，表現了嚴格的部分與整體關係，譬如人有五官。
* 聚合(Aggregation)：`弱`的擁有關係，表現的是A可以包含B，但B不等於A的一部分，譬如球隊與球員的關係。

在實作時優先考慮使用合成/聚合原則，因為它可以幫助你維持每個類別集中在單個任務上，這樣類別與類別的繼承層次規模會較小。

# 類別圖

![橋接模式](https://github.com/BryanYu/DesignPatternPractice/blob/master/Bridage/ClassDiagram1.png)


