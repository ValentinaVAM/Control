**Итоговая проверочная работа.**
=

**Задача.**

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3-м символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивам

***Описание решения.***

Пользователь вводит количество строк, затем последовательно вводит строки. Введенные строки выводим в виде массива из строк. Создаем метод  NewArrayStrings, в него задаем введенный пользователем массив из строк.
Инициализируем вспомогательную переменную count = 0.
Вычисляем количество строк, длинна которых меньше либо равна 3-м символам.
В цикле for проходим по каждой строке массива. На каждой итерации сверяем длину строки. Если длина меньше или равна 3-м символам, записываем эту строку в новый масив и инкрементируем ранее инициализируемую переменную count и счётчик цикла for. Если длина больше 3-х символов, то инкрементируем только счётчик цикла for. 
Далее с помощью метода PrintArray выводим на печать новый массив из строк, длина которых <=3. 