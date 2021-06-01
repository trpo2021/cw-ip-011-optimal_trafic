#include <cmath>
#include <fstream>
#include <iostream>
#include <libchessviz/struc.h>
#include <list>
using namespace std;

int CheckTarif2(tarifs* tarif, int N, int RequiredIndicators)
{
    int Difference=9999, StrokSum, StrokNumber;
    for (int i = 0; i < N; i++) {
        StrokSum = tarif[i].minutes + tarif[i].sms + tarif[i].gigabytes;
        if ((StrokSum - RequiredIndicators) > 0) {

            if(Difference > StrokSum - RequiredIndicators)
            {Difference =  StrokSum - RequiredIndicators;
            StrokNumber = i;
            }
        }
    }
    return StrokNumber;
}