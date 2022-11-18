# Домашнее задание. 

## Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


## [Блок-схема](FinalEx/Scheme.png) | [Код](FinalEx/Program.cs)


## Текстовое описание решения задачи: 
1. Создание метода для ввода количества элементов с проверкой введенного количества элементов (значение должно быть больше 0) с применением рекурсии. 
2. Создание исходного массива, длина которого равняется значению, введенном пользователем.  
3. Создание метода для заполнения массива данными. введенными пользователем с клавиатуры с приминением цикла for.
4. Создание метода для определения количества строк в массиве, состоящих из 3 и меньше символов, для определения длины нового массива. 
Цикл for c условием длины строки <= 3 символам.
5. Проверка количества искомых элементов (по предыдущему пункту), если равно 0 - вывод сообщения об отсутствии искомых элементов. Если больше 0 - создание нового массива с соответствующей длиной. 
6. Создание метода для перевода искомых строк из заданного массива в новый. 
7. Создание метода для вывода найденных элементов в консоль с применением рекурсии. 



