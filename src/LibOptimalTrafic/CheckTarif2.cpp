#include <cmath>
#include <fstream>
#include <iostream>
#include <LibOptimalTrafic/struc.h>
#include <list>
using namespace std;

int CheckTarif2(tarifs* tarif, int N, int Minut, int SMS, int Gig)
{
    int Difference = 9999, StrokSum, StrokNumber = 10, RequiredIndicators;
    RequiredIndicators = Gig + SMS + Minut;
    for (int i = 0; i < N; i++) {
        StrokSum = tarif[i].minutes + tarif[i].sms + tarif[i].gigabytes;
        if (tarif[i].gigabytes >= Gig && tarif[i].sms >= SMS
            && tarif[i].minutes >= Minut) {
            if (Difference > StrokSum - RequiredIndicators) {
                Difference = StrokSum - RequiredIndicators;
                StrokNumber = i;
            }
        }
    }
    if (StrokNumber == 10) {
        for (int i = 0; i < N; i++) {
            StrokSum = tarif[i].minutes + tarif[i].sms + tarif[i].gigabytes;
            if (i == 0) {
                StrokNumber = 0;
                Difference = abs(RequiredIndicators - StrokSum);
            }
            if (Difference > abs(RequiredIndicators - StrokSum)) {
                Difference = abs(RequiredIndicators - StrokSum);
                StrokNumber = i;
            }
        }
    }
    return StrokNumber;
}