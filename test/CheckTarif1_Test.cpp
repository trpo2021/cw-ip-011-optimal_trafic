#include <LibOptimalTrafic/CheckTarif1.h>
#include <LibOptimalTrafic/Input.h>
#include <LibOptimalTrafic/struc.h>
#include <cmath>
#include <ctest.h>
#include <fstream>
#include <iostream>
#include <list>
using namespace std;

CTEST(test1, Output_test_MTS)
{
    int StrokNumber;
    int N = 4;
    string tarifOperatorFile = "TarifsMTS.txt";
    int RequiredIndicators = 777;
    tarifs* tarif = Input(N, tarifOperatorFile);
    StrokNumber = CheckTarif1(tarif, N, RequiredIndicators);
    cout << tarif[StrokNumber].name << "\t" << tarif[StrokNumber].minutes
         << "\t" << tarif[StrokNumber].sms << "\t"
         << tarif[StrokNumber].gigabytes << endl;
    ASSERT_EQUAL(1, StrokNumber);
}

CTEST(test2, Output_test_Megafon)
{
    int StrokNumber;
    int N = 4;
    string tarifOperatorFile = "TarifsMegafon.txt";
    int RequiredIndicators = 900;
    tarifs* tarif = Input(N, tarifOperatorFile);
    StrokNumber = CheckTarif1(tarif, N, RequiredIndicators);
    cout << tarif[StrokNumber].name << "\t" << tarif[StrokNumber].minutes
         << "\t" << tarif[StrokNumber].sms << "\t"
         << tarif[StrokNumber].gigabytes << endl;
    ASSERT_EQUAL(2, StrokNumber);
}

CTEST(test3, Output_test_Bilain)
{
    int StrokNumber;
    int N = 4;
    string tarifOperatorFile = "TarifsBilain.txt";
    int RequiredIndicators = 2000;
    tarifs* tarif = Input(N, tarifOperatorFile);
    StrokNumber = CheckTarif1(tarif, N, RequiredIndicators);
    cout << tarif[StrokNumber].name << "\t" << tarif[StrokNumber].minutes
         << "\t" << tarif[StrokNumber].sms << "\t"
         << tarif[StrokNumber].gigabytes << endl;
    ASSERT_EQUAL(3, StrokNumber);
}