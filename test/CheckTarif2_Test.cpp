#include <cmath>
#include <ctest.h>
#include <fstream>
#include <iostream>
#include <LibOptimalTrafic/CheckTarif2.h>
#include <LibOptimalTrafic/Input2.h>
#include <LibOptimalTrafic/struc.h>
#include <list>
using namespace std;

CTEST(test1, Output_test_MTS2)
{
    int StrokNumber;
    int N = 4;
    int Minut = 222;
    int SMS = 223;
    int Gig = 222;
    string tarifOperatorFile = "TarifsMTS.txt";
    tarifs* tarif = Input2(N, tarifOperatorFile);
    StrokNumber = CheckTarif2(tarif, N, Minut, SMS, Gig);
    cout << tarif[StrokNumber].name << "\t" << tarif[StrokNumber].minutes
         << "\t" << tarif[StrokNumber].sms << "\t"
         << tarif[StrokNumber].gigabytes << endl;
    ASSERT_EQUAL(3, StrokNumber);
}

CTEST(test2, Output_test_Megafon2)
{
    int StrokNumber;
    int N = 4;
    int Minut = 320;
    int SMS = 230;
    int Gig = 320;
    string tarifOperatorFile = "TarifsMegafon.txt";
    tarifs* tarif = Input2(N, tarifOperatorFile);
    StrokNumber = CheckTarif2(tarif, N, Minut, SMS, Gig);
    cout << tarif[StrokNumber].name << "\t" << tarif[StrokNumber].minutes
         << "\t" << tarif[StrokNumber].sms << "\t"
         << tarif[StrokNumber].gigabytes << endl;
    ASSERT_EQUAL(2, StrokNumber);
}

CTEST(test3, Output_test_Bilain2)
{
    int StrokNumber;
    int N = 4;
    int Minut = 450;
    int SMS = 450;
    int Gig = 450;
    string tarifOperatorFile = "TarifsBilain.txt";
    tarifs* tarif = Input2(N, tarifOperatorFile);
    StrokNumber = CheckTarif2(tarif, N, Minut, SMS, Gig);
    cout << tarif[StrokNumber].name << "\t" << tarif[StrokNumber].minutes
         << "\t" << tarif[StrokNumber].sms << "\t"
         << tarif[StrokNumber].gigabytes << endl;
    ASSERT_EQUAL(2, StrokNumber);
}