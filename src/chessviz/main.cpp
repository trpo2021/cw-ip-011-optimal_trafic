#include <cmath>
#include <fstream>
#include <iostream>
#include <list>
#include <libchessviz/struc.h>
#include <libchessviz/Input.h>
#include <libchessviz/CheckTarif.h>
#include <libchessviz/Output.h>
#include <libchessviz/GetValue.h>

using namespace std;




// void Output(tarifs* tarif, int StrokNumber)
//{
//
//        cout << tarif[StrokNumber].name << "\t" <<
//        tarif[StrokNumber].minutes<< "\t" << tarif[StrokNumber].sms << "\t"<<
//        tarif[StrokNumber].gigabytes<< endl;
//
//}
//
// int CheckTarif(tarifs* tarif, int N, int RequiredIndicators)
//{
//    int Difference, StrokSum, StrokNumber;
//    for (int i = 0; i < N; i++) {
//            StrokSum = tarif[i].minutes + tarif[i].sms + tarif[i].gigabytes;
//        if (i == 0) {
//            StrokNumber = 0;
//             Difference = abs(RequiredIndicators - StrokSum);
//        }
//        if (Difference > abs(RequiredIndicators - StrokSum)) {
//            Difference = abs(RequiredIndicators - StrokSum);
//            StrokNumber = i;
//        }
//    }
//    return StrokNumber;
//}

int main()
{
    setlocale(LC_ALL, "Rus"); // Подключение русского языка
    int Gig;
    int SMS;
    int Minut;
    int Operator;
    int N;
    int RequiredIndicators;
    int StrokNumber;
    string tarifOperatorFile;

    cout << "Введите кол-во минут:\n";
    //cin >> Gig;
    Minut=GetValue();
    cout << "Введите кол-во гиг:\n";
    //cin >> SMS;
    Gig=GetValue();
    cout << "Введите кол-во смс:\n";
    //cin >> Minut;
    SMS=GetValue();
    cout << "Выберите оператора: 1.МТС 2.Мегафон 3.Билайн\n";
    cin >> Operator;
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
    N = 4;
    tarifs* tarif = Input(N, tarifOperatorFile);
    RequiredIndicators = Gig + SMS + Minut;
    StrokNumber = CheckTarif(tarif, N, RequiredIndicators);
    Output(tarif, StrokNumber);
}
