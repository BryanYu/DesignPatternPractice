# Iterator Pattern - 迭代器模式

定義：提供一種方法依序存取一個集合物件中的各個元素，且不會暴露該物件的內部結構。

迭代器模式就是分離集合物件的遍歷行為，抽象出一個迭代器類別，可以不暴露集合內部的物件結構，又可以讓外部程式碼透明的存取集合內的資料。

在.net中，我們很常使用`foreach in`來遍歷物件，其背後的原理就是只要實作`IEumerator`與`IEnumerable`介面，就可以使用`foreach in`來操作集合。
可以參考下列程式碼的實作

      List<int> temps = new List<int> { 1, 2, 3, 4, 5 };

      //foreach
      foreach (var temp in temps)
      {
          Console.WriteLine(temp);
      }
      //Enumeator
      List<int> temps2 = new List<int> { 6, 7, 8, 9, 10 };
      var tempEnumerator = temps2.GetEnumerator();
      while (tempEnumerator.MoveNext())
      {
          Console.WriteLine(tempEnumerator.Current);
      }
      Console.Read();



