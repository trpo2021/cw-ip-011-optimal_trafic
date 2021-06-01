#pragma once
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
        //cout<<tarif[1].name<<"\t"<<tarif[1].minutes<<"\t"<<tarif[1].sms<<"\t"<<tarif[1].gigabytes<<endl;
        fin.close();
        return tarif;
    }
