#include <iostream>
using namespace std;

int SwitchOperator()
{
    while (true) // цикл продолжается до тех пор, пока пользователь не введет
                 // корректное значение
    {
        int a;
        cin >> a;

        // Проверка на предыдущее извлечение
        if (cin.fail()) // если предыдущее извлечение оказалось неудачным,
        {
            cin.clear(); // то возвращаем cin в 'обычный' режим работы
            cin.ignore(2000, '\n'); // и удаляем значения предыдущего ввода из
                                    // входного буфера
            cout << "Oops, that input is invalid.  Please try again.\n";
        } else if (a == 1 || a == 2 || a == 3) {
            cin.ignore(2000, '\n'); // удаляем лишние значения
            return a;
        } else {
            int SwitchOperator();
        }
    }
}