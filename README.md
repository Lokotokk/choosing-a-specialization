Необходимо написать программу, которая из имеющегося массива из строк формирует массив (задается с клавиатуры либо на страте выполнения алгоритма) из строк, длина которых меньше либо равна 3 символов.
**Логика программы**: 
1. Создаём строковый массив с заданным размером.
2. С помощью метода FillArray заполяем массив (пользователь вводит каждый элемент массива).
3. С помошью метода PrintArrayString печатаем получившийся массив. 
4. Создаём метод, который формирует массив из строк, длина которых меньше либо равно 3 символам:
 4.1.) определяем размер нового массива: 
 - изначально задаем его равным нулю;
 -  проходим по всему изначально сформированному массиву, отбирая элементы с тремя или менее символами         (увеличиваем изначально заданный размер).
 4.2.) создаем новый массив с найденным размером:
 - определяем индекс равным нулю (счетчик, который будет переключать элементы нового массива);
 - проходим по старому массиву и записываем элемент в новый, если он равен или менее 3 символов.
 - увеличиваем счетчик для перехода к следующему элементу нового массива.
 5. Печатаем новый массив с помошью метода PrintArrayString.