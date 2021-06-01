#include <iostream>
using namespace std;

int GetValue()
{
    while (true)

    {
        int a;
        cin >> a;

        if (cin.fail()) {
            cin.clear();
            cin.ignore(2000, '\n');

            cout << "Ошибка, введен недопустимый символ, введите правильную "
                    "цифру.\n";
        } else {
            cin.ignore(2000, '\n');

            return a;
        }
    }
}
