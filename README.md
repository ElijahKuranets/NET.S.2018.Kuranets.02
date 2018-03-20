# NET.S.2018.Kuranets.02
Second day of developing ASP.NET MVC web applications in EPAM
1.	Даны два целых знаковых четырех байтовых числа и две позиции битов i и j (i<j). Реализовать алгоритм InsertNumber вставки битов с j-ого по i-ый бит одного числа в другое так, чтобы биты второго числа занимали позиции с бита j по бит i (биты нумеруются справа налево). Разработать модульные тесты (NUnit и(!) MS Unit Test) для тестирования метода. (Ниже пояснение к алгоритму).  
2.	Реализовать метод FindNextBiggerNumber, который принимает положительное целое число и возвращает ближайшее наибольшее целое, состоящее из цифр исходного числа, и null (или -1), если такого числа не существует.

•	Разработать модульные тесты (NUnit или MS Unit Test) для тестирования метода. Примерные тест-кейсы:
  <li>
[TestCase(12, ExpectedResult = 21)]
  <li>
[TestCase(513, ExpectedResult = 531)]
  <li>
[TestCase(2017, ExpectedResult = 2071)]
  <li>
[TestCase(414, ExpectedResult = 441)]
  <li>  
[TestCase(144, ExpectedResult = 414)]
  <li>  
[TestCase(1234321, ExpectedResult = 1241233)]
  <li>
[TestCase(1234126, ExpectedResult = 1234162)]
  <li>
[TestCase(3456432, ExpectedResult = 3462345)]
  <li>  
[TestCase(10, ExpectedResult = -1)]
  <li>
[TestCase(20, ExpectedResult = -1)]

•	Добавить к методу FindNextBiggerNumber возможность вернуть время нахождения заданного числа, рассмотрев различные языковые возможности. Разработать модульные тесты (NUnit или MS Unit Test) для тестирования метода.
