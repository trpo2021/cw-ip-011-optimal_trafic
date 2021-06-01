#include <cmath>
#include <ctest.h>
#include <fstream>
#include <iostream>
#include <libchessviz/CheckTarif.h>
#include <libchessviz/InputMegafon.h>
#include <libchessviz/struc.h>
#include <list>
using namespace std;

CTEST(test2, Output_test_Megafon)
{
    int StrokNumber;
    int N = 4;
    string tarifOperatorFile = "TarifsMegafon.txt";
    int RequiredIndicators = 900;
    tarifs* tarif = InputMegafon(N, tarifOperatorFile);
    StrokNumber = CheckTarif(tarif, N, RequiredIndicators);
    cout << tarif[StrokNumber].name << "\t" << tarif[StrokNumber].minutes
         << "\t" << tarif[StrokNumber].sms << "\t"
         << tarif[StrokNumber].gigabytes << endl;
    ASSERT_EQUAL(2, StrokNumber);
}
