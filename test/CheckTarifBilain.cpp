#include <cmath>
#include <ctest.h>
#include <fstream>
#include <iostream>
#include <libchessviz/CheckTarif.h>
#include <libchessviz/InputBilain.h>
#include <libchessviz/struc.h>
#include <list>
using namespace std;

CTEST(test3, Output_test_Bilain)
{
    int StrokNumber;
    int N = 4;
    string tarifOperatorFile = "TarifsBilain.txt";
    int RequiredIndicators = 2000;
    tarifs* tarif = InputBilain(N, tarifOperatorFile);
    StrokNumber = CheckTarif(tarif, N, RequiredIndicators);
    cout << tarif[StrokNumber].name << "\t" << tarif[StrokNumber].minutes
         << "\t" << tarif[StrokNumber].sms << "\t"
         << tarif[StrokNumber].gigabytes << endl;
    ASSERT_EQUAL(3, StrokNumber);
}
