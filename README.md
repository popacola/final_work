# **Описание решения**
## _1. Задание начального массива_
Задаем размер массива (количество элементов) и записываем сами элементы.
## _2. Обработка массива_
Проверяем сколько элементов соответствует условию (элемент <= 3). Исплользуем для этого оператор  __*<u>if (array[i] <= 3)</u>*__  вложеный в цикл __*<u>for (i < array.GetLength(0); i++)</u>*__.

На выходе этого метода получаем количество элементов нового массива.

## _3. Создание нового массива_
Тут будем использовать вложенные циклы. Во внешенем цикле мы будем присваивать элементам нового массива значения из вложенного цикла. Во вложенном цикле перебирается начальный массив по условию задачи. После соответсвия вложенный цикл присваивает значение новому массиву и запускает следующую итерацию внешнего цикла.

## _4. Вывод данных_
Новый массив выводится в консоль.