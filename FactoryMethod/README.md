# Factory Mehtod Pattern - 工廠方法模式

定義：定義一個用於建立物件的介面，讓子類別決定實體化哪一個類別。工廠方法使一個類別的實體化延遲到其子類別。

簡單工廠與工廠方法的差別：
* 簡單工廠：在工廠類別中包含了必要邏輯判斷，根據用戶端程式碼來決定要實體化哪一個類別，**將來新增功能時只需修改簡單工廠類別(增加新的判斷邏輯)**。
* 工廠方法：將簡單工廠的邏輯判斷，移至用戶端，**將來要新增功能需修改用戶端程式碼**。

# 類別圖

![簡單工廠模式](https://github.com/BryanYu/DesignPatternPractice/blob/master/FactoryMethod/ClassDiagram1.png)


