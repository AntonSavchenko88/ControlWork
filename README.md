# FinalTask
> Задача :
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
>
## *Описание алгоритма решения:*
1. Сначала вводится размерность изначального массива (ввод осуществляется с консоли пользователем).
2. Объявляются два массива: изначальный и вторый такой же длины как и изначальный.
3. Описывается метод, в котором цикл равный размерности изначального массива осуществляет заполнение массива *(данные вводятся с консоли пользователем)*.
4. Выводится введенный массив.
5. Описывается метод который циклом проходит по всем элементам введенного *(изначального массива)* одновременно проверяя условие *(текущий элемент массива <=3)*, если да, то элемент первого массива заносится в **count** элемент второго массива. Переменная count введена для осуществления подсчета количества элементов удовлетворяющих условию **if**. После  переменная **count** на 1 и возвращается к циклу.
6. По окончании цикла при помощи переменной **count** размер второго массива с занесенными в него элементами из изначального массива уменьшается *(или остается прежним)*.
7. Осуществляется вывод проверенного массива.