#pragma once
#include <iostream>
using namespace std;

tarifs* Input(int n, string tarifOperatorFile)
{
    tarifs* tarif = new tarifs[n];
    string path = tarifOperatorFile;
    ifstream fin;
    fin.open(path);
    for (int i = 0; i < n; i++) {
        fin >> tarif[i].name;
        fin >> tarif[i].minutes;
        fin >> tarif[i].sms;
        fin >> tarif[i].gigabytes;
    }
    fin.close();
    return tarif;
}
