#include <cmath>
#include <fstream>
#include <iostream>
#include <libchessviz/CheckTarif1.h>
#include <libchessviz/CheckTarif2.h>
#include <libchessviz/GetValue.h>
#include <libchessviz/Input.h>
#include <libchessviz/Output.h>
#include <libchessviz/SwitchOperator.h>
#include <libchessviz/struc.h>
#include <list>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Rus");
    int Gig;
    int SMS;
    int Minut;
    int Operator = 0;
    int N;
    int RequiredIndicators;
    int StrokNumber;
    int Podbor;
    int SposobPodbor;
    string tarifOperatorFile;

    cout << "Введите кол-во минут:\n";
    Minut = GetValue();
    cout << "Введите кол-во гиг:\n";
    Gig = GetValue();
    cout << "Введите кол-во смс:\n";
    SMS = GetValue();

    while (Operator < 1 || Operator > 3) {
        cout << "Введите название необходимого оператора: 1.МТС 2.Мегафон "
                "3.Билайн \n";
        Operator = GetValue();
    }

    switch (Operator) {
    case 1:
        tarifOperatorFile = "TarifsMTS.txt";
        break;
    case 2:
        tarifOperatorFile = "TarifsMegafon.txt";
        break;
    case 3:
        tarifOperatorFile = "TarifsBilain.txt";
        break;
    }

    do {
        cout << "Выберите способ подбора тарифа: 1.Подбор наиболее ближайшего "
                "тарифа(возможна нехватка заданных данных) 2.Подбор тарифа, "
                "полностью удовлетворяющего заданным условиям\n";
        cin >> Podbor;
        switch (Podbor) {
        case 1:
            SposobPodbor = 1;
            break;
        case 2:
            SposobPodbor = 2;
            break;
        }
    } while (SposobPodbor == 1 || SposobPodbor == 2);

    N = 4;
    tarifs* tarif = Input(N, tarifOperatorFile);
    RequiredIndicators = Gig + SMS + Minut;
    if (SposobPodbor == 1)
        StrokNumber = CheckTarif1(tarif, N, RequiredIndicators);
    if (SposobPodbor == 2)
        StrokNumber = CheckTarif2(tarif, N, RequiredIndicators);
    Output(tarif, StrokNumber);
}
