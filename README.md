# ControlWork
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

# Решение

1) Создадим метод, который будет проверять массив на соответствие требованиям.
2) Создаём массив внутри метода, который будет возвращён, а так же переменную count, которая будет увеличиваться, если в этот массив будет добавляться новое значение.
3) Создаём цикл, который будет не больше размера первого массива.
4) Если ячейка массива будет заполнена, то функция будет выполняться дальше. (Сделано чтобы избежать ошибки с пустой ячейкой.)
5) Проверяется содержимое ячейки на размер с помощью метода Lenght, если оно меньше или равно 3, то значение ячейки переносится в новый массив, а число count увеличивается.
6) На выходе получаем искомый массив.
