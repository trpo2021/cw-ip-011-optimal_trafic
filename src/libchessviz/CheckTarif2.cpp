#include <cmath>
#include <fstream>
#include <iostream>
#include <libchessviz/struc.h>
#include <list>
using namespace std;

int CheckTarif2(tarifs* tarif, int N, int Gig, int SMS, int Minut)
{
    int Difference = 9999, StrokSum, StrokNumber, RequiredIndicators;
    RequiredIndicators = Gig + SMS + Minut;
    for (int i = 0; i < N; i++) {
        StrokSum = tarif[i].minutes + tarif[i].sms + tarif[i].gigabytes;
        if (tarif[i].gigabytes > Gig && tarif[i].sms > SMS
            && tarif[i].minutes > Minut) {
            if (Difference > StrokSum - RequiredIndicators) {
                Difference = StrokSum - RequiredIndicators;
                StrokNumber = i;
            }
        }
    }
    return StrokNumber;
}