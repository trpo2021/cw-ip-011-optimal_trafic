#include <cmath>
#include <ctest.h>
#include <fstream>
#include <iostream>
#include <libchessviz/CheckTarif.h>
#include <libchessviz/Input.h>
#include <libchessviz/struc.h>
#include <list>
using namespace std;

CTEST(test1, Output_test_MTS)
{
    int StrokNumber;
    int N = 4;
    string tarifOperatorFile = "TarifsMTS.txt";
    int RequiredIndicators = 777;
    tarifs* tarif = Input(N, tarifOperatorFile);
    StrokNumber = CheckTarif(tarif, N, RequiredIndicators);
    cout << tarif[StrokNumber].name << "\t" << tarif[StrokNumber].minutes
         << "\t" << tarif[StrokNumber].sms << "\t"
         << tarif[StrokNumber].gigabytes << endl;
    ASSERT_EQUAL(1, StrokNumber);
}
