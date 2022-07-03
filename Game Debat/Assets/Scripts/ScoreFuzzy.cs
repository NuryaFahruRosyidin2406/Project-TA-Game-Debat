using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreFuzzy : MonoBehaviour
{
    static int isi, penyampaian, sampel, strategi;
    float na, hasilkeluaran;
    int hasilakhir;

    public class fuzzy_mamdani
    {
        int k;
        float memberIsiKurangBagus, memberIsiCukupBagus, memberIsiBagus, memberIsiBagusSekali;
        float memberPenyampaianKurangBagus, memberPenyampaianCukupBagus, memberPenyampaianBagus;
        float memberStrategiKurangBagus, memberStrategiCukupBagus, memberStrategiBagus;
        float deltaX, deltaY, deltaZ;
        float hasilPembilang, hasilPenyebut, hasilDefuzzifikasi;
        float jumlah_sampelX, jumlah_sampelY, jumlah_sampelZ, jumlah_samir;
        float mirlangX, mirlangY, mirlangZ;
        float pembilangX, pembilangY, pembilangZ, pembilangmir;
        float pengaliX, pengaliY, pengaliZ;
        float terbesarX, terbesarY, terbesarZ;
        float titik_sampelX, titik_sampelY, titik_sampelZ;

        //Keanggotaan isi
        public void anggotaisi(float inputIsi)
        {
            Debug.Log("Nilai " + inputIsi + " masuk anggota isi");
            // Nilai Isi Kurang Bagus (Trapesium)
            if (inputIsi >= 0 && inputIsi <= 24)
            {
                memberIsiKurangBagus = 1;
                Debug.Log("Nilai member isi Kurang Bagus dengan kondisi inputIsi >= 0 && inputIsi <= 24 adalah " + memberIsiKurangBagus);
            }
            else if (inputIsi > 24 && inputIsi < 26)
            {
                memberIsiKurangBagus = ((26 - inputIsi) / 2);
                Debug.Log("Nilai member isi Kurang Bagus dengan kondisi inputIsi > 24 && inputIsi < 26 adalah " + memberIsiKurangBagus);
            }
            else
            {
                memberIsiKurangBagus = 0;
                Debug.Log("Nilai member isi Kurang Bagus adalah " + memberIsiKurangBagus);
            }

            // Nilai Isi Cukup Bagus (Trapesium)
            if (inputIsi >= 26 && inputIsi <= 27)
            {
                memberIsiCukupBagus = 1;
                Debug.Log("Nilai member isi Cukup Bagus dengan kondisi inputIsi >= 26 && inputIsi <= 27 adalah " + memberIsiCukupBagus);
            }
            else if (inputIsi > 24 && inputIsi < 26)
            {
                memberIsiCukupBagus = ((inputIsi - 24) / 2);
                Debug.Log("Nilai member isi Cukup Bagus dengan kondisi inputIsi > 24 && inputIsi < 26 adalah " + memberIsiCukupBagus);
            }
            else if (inputIsi > 27 && inputIsi < 28)
            {
                memberIsiCukupBagus = ((28 - inputIsi) / 1);
                Debug.Log("Nilai member isi Cukup Bagus dengan kondisi inputIsi > 27 && inputIsi < 28 adalah " + memberIsiCukupBagus);
            }
            else
            {
                memberIsiCukupBagus = 0;
                Debug.Log("Nilai member isi Cukup Bagus adalah " + memberIsiCukupBagus);
            }

            // Nilai Isi Bagus (Trapesium)
            if (inputIsi >= 28 && inputIsi <= 30)
            {
                memberIsiBagus = 1;
                Debug.Log("Nilai member isi Bagus dengan kondisi inputIsi >= 28 && inputIsi <= 30 adalah " + memberIsiBagus);
            }
            else if (inputIsi > 27 && inputIsi < 28)
            {
                memberIsiBagus = ((inputIsi - 27) / 1);
                Debug.Log("Nilai member isi Bagus dengan kondisi inputIsi > 27 && inputIsi < 28 adalah " + memberIsiBagus);
            }
            else if (inputIsi > 30 && inputIsi < 32)
            {
                memberIsiBagus = ((32 - inputIsi) / 2);
                Debug.Log("Nilai member isi Bagus dengan kondisi inputIsi > 30 && inputIsi < 32 adalah " + memberIsiBagus);
            }
            else
            {
                memberIsiBagus = 0;
                Debug.Log("Nilai member isi Bagus adalah " + memberIsiBagus);
            }

            // Nilai Isi Bagus Sekali (Trapesium)
            if (inputIsi >= 32 && inputIsi <= 40)
            {
                memberIsiBagusSekali = 1;
                Debug.Log("Nilai member isi Bagus Sekali dengan kondisi inputIsi >= 32 && inputIsi <= 40 adalah " + memberIsiBagusSekali);
            }
            else if (inputIsi > 30 && inputIsi < 32)
            {
                memberIsiBagusSekali = ((inputIsi - 30) / 2);
                Debug.Log("Nilai member isi Bagus Sekali dengan kondisi inputIsi > 30 && inputIsi < 32 adalah " + memberIsiBagusSekali);
            }
            else
            {
                memberIsiBagusSekali = 0;
                Debug.Log("Nilai member isi Bagus Sekali adalah " + memberIsiBagusSekali);
            }
        }

        //Keanggotaan penyampaian
        public void anggotapenyampaian(float inputPenyampaian)
        {
            Debug.Log("Nilai " + inputPenyampaian + " masuk anggota penyampaian");
            // Nilai Penyampaian Kurang Bagus (Trapesium)
            if (inputPenyampaian >= 0 && inputPenyampaian <= 24)
            {
                memberPenyampaianKurangBagus = 1;
                Debug.Log("Nilai member penyampaian Kurang Bagus dengan kondisi inputPenyampaian >= 0 && inputPenyampaian <= 24 adalah " + memberPenyampaianKurangBagus);
            }
            else if (inputPenyampaian > 24 && inputPenyampaian < 26)
            {
                memberPenyampaianKurangBagus = ((26 - inputPenyampaian) / 2);
                Debug.Log("Nilai member penyampaian Kurang Bagus dengan kondisi inputPenyampaian > 24 && inputPenyampaian < 26 adalah " + memberPenyampaianKurangBagus);
            }
            else
            {
                memberPenyampaianKurangBagus = 0;
                Debug.Log("Nilai member penyampaian Kurang Bagus adalah " + memberPenyampaianKurangBagus);
            }

            // Nilai Penyampaian Cukup Bagus (Trapesium)
            if (inputPenyampaian >= 26 && inputPenyampaian <= 30)
            {
                memberPenyampaianCukupBagus = 1;
                Debug.Log("Nilai member penyampaian Cukup Bagus dengan kondisi inputPenyampaian >= 26 && inputPenyampaian <= 27 adalah " + memberPenyampaianCukupBagus);
            }
            else if (inputPenyampaian > 24 && inputPenyampaian < 26)
            {
                memberPenyampaianCukupBagus = ((inputPenyampaian - 24) / 2);
                Debug.Log("Nilai member penyampaian Cukup Bagus dengan kondisi inputPenyampaian > 24 && inputPenyampaian < 26 adalah " + memberPenyampaianCukupBagus);
            }
            else if (inputPenyampaian > 30 && inputPenyampaian < 32)
            {
                memberPenyampaianCukupBagus = ((32 - inputPenyampaian) / 2);
                Debug.Log("Nilai member penyampaian Cukup Bagus dengan kondisi inputPenyampaian > 30 && inputPenyampaian < 32 adalah " + memberPenyampaianCukupBagus);
            }
            else
            {
                memberPenyampaianCukupBagus = 0;
                Debug.Log("Nilai member penyampaian Cukup Bagus adalah " + memberPenyampaianCukupBagus);
            }

            // Nilai Isi Bagus (Trapesium)
            if (inputPenyampaian >= 32 && inputPenyampaian <= 40)
            {
                memberPenyampaianBagus = 1;
                Debug.Log("Nilai member penyampaian Bagus dengan kondisi inputPenyampaian >= 32 && inputPenyampaian <= 40 adalah " + memberPenyampaianBagus);
            }
            else if (inputPenyampaian > 30 && inputPenyampaian < 32)
            {
                memberPenyampaianBagus = ((inputPenyampaian - 30) / 2);
                Debug.Log("Nilai member penyampaian Bagus dengan kondisi inputPenyampaian > 30 && inputPenyampaian < 32 adalah " + memberPenyampaianBagus);
            }
            else
            {
                memberPenyampaianBagus = 0;
                Debug.Log("Nilai member penyampaian Bagus adalah " + memberPenyampaianBagus);
            }
        }

        //Keanggotaan strategi
        public void anggotastrategi(float inputStrategi)
        {
            Debug.Log("Nilai " + inputStrategi + " masuk anggota strategi");
            // Nilai Strategi Kurang Bagus (Trapesium)
            if (inputStrategi >= 0 && inputStrategi <= 1)
            {
                memberStrategiKurangBagus = 1;
                Debug.Log("Nilai member strategi Kurang Bagus dengan kondisi inputStrategi >= 0 && inputStrategi <= 1 adalah " + memberStrategiKurangBagus);
            }
            else if (inputStrategi > 1 && inputStrategi < 2)
            {
                memberStrategiKurangBagus = ((2 - inputStrategi) / 1);
                Debug.Log("Nilai member strategi Kurang Bagus dengan kondisi inputStrategi > 1 && inputStrategi < 2 adalah " + memberStrategiKurangBagus);
            }
            else
            {
                memberStrategiKurangBagus = 0;
                Debug.Log("Nilai member strategi Kurang Bagus adalah " + memberStrategiKurangBagus);
            }

            // Nilai Strategi Cukup Bagus (Segitiga)
            if (inputStrategi == 2)
            {
                memberStrategiCukupBagus = 1;
                Debug.Log("Nilai member strategi Cukup Bagus dengan kondisi inputStrategi == 2 adalah " + memberStrategiCukupBagus);
            }
            else if (inputStrategi > 1 && inputStrategi < 2)
            {
                memberStrategiCukupBagus = ((inputStrategi - 1) / 1);
                Debug.Log("Nilai member strategi Cukup Bagus dengan kondisi inputStrategi > 1 && inputStrategi < 2 adalah " + memberStrategiCukupBagus);
            }
            else if (inputStrategi > 2 && inputStrategi < 3)
            {
                memberStrategiCukupBagus = ((3 - inputStrategi) / 1);
                Debug.Log("Nilai member strategi Cukup Bagus dengan kondisi inputStrategi > 2 && inputStrategi < 3 adalah " + memberStrategiCukupBagus);
            }
            else
            {
                memberStrategiCukupBagus = 0;
                Debug.Log("Nilai member strategi Cukup Bagus adalah " + memberStrategiCukupBagus);
            }

            // Nilai Strategi Bagus (Segitiga)
            if (inputStrategi == 3)
            {
                memberStrategiBagus = 1;
                Debug.Log("Nilai member strategi Bagus dengan kondisi inputStrategi == 3 adalah " + memberStrategiBagus);
            }
            else if (inputStrategi > 2 && inputStrategi < 3)
            {
                memberStrategiBagus = ((inputStrategi - 2) / 1);
                Debug.Log("Nilai member strategi Bagus dengan kondisi inputStrategi > 2 && inputStrategi < 3 adalah " + memberStrategiBagus);
            }
            else
            {
                memberStrategiBagus = 0;
                Debug.Log("Nilai member strategi Bagus adalah " + memberStrategiBagus);
            }
        }

        // Bagian inferensi
        public void inferensi()
        {
            float[] nilaiKondisi = new float[10];
            string[] kondisi = new string[10];
            float[] nilaiIsi = { memberIsiKurangBagus, memberIsiCukupBagus, memberIsiBagus, memberIsiBagusSekali };
            float[] nilaiPenyampaian = { memberPenyampaianKurangBagus, memberPenyampaianCukupBagus, memberPenyampaianBagus };
            float[] nilaiStrategi = { memberStrategiKurangBagus, memberStrategiCukupBagus, memberStrategiBagus };

            k = 0;
            terbesarX = 0;
            terbesarY = 0;
            terbesarZ = 0;

            // Cek isi nilai array
            for (int a = 0; a < nilaiIsi.Length; a++)
            {
                Debug.Log(a + ". Nilai array dari variabel nilaiIsi " + nilaiIsi[a]);
            }
            for (int b = 0; b < nilaiPenyampaian.Length; b++)
            {
                Debug.Log(b + ". Nilai array dari variabel nilaiPenyampaian " + nilaiPenyampaian[b]);
            }
            for (int c = 0; c < nilaiStrategi.Length; c++)
            {
                Debug.Log(c + ". Nilai array dari variabel nilaiStrategi " + nilaiStrategi[c]);
            }

            // Menentukan Rules dan nilai minimum
            for (int i = 0; i < nilaiIsi.Length; i++)
            {
                for (int j = 0; j < nilaiPenyampaian.Length; j++)
                {
                    for (int l = 0; l < nilaiStrategi.Length; l++)
                    {
                        // rules fuzzy game debat
                        if (nilaiIsi[i] > 0 && nilaiPenyampaian[j] > 0 && nilaiStrategi[l] > 0)
                        {
                            if (nilaiIsi[i] <= nilaiPenyampaian[j] && nilaiIsi[i] <= nilaiStrategi[l])
                            {
                                nilaiKondisi[k] = nilaiIsi[i];
                                Debug.Log("Masuk nilai kondisi untuk nilai isi = " + nilaiKondisi[k]);
                            }
                            else if (nilaiPenyampaian[j] <= nilaiIsi[i] && nilaiPenyampaian[j] <= nilaiStrategi[l])
                            {
                                nilaiKondisi[k] = nilaiPenyampaian[j];
                                Debug.Log("Masuk nilai kondisi untuk nilai penyampaian = " + nilaiKondisi[k]);
                            }
                            else
                            {
                                nilaiKondisi[k] = nilaiStrategi[l];
                                Debug.Log("Masuk nilai kondisi untuk nilai strategi = " + nilaiKondisi[k]);
                            }

                            if (i == 0 && j == 0 && l <= 2)
                            {
                                kondisi[k] = "Kurang_Bagus";
                            }
                            else if (i == 0 && j == 1 && l == 0)
                            {
                                kondisi[k] = "Kurang_Bagus";
                            }
                            else if (i == 0 && j == 1 && l >= 1)
                            {
                                kondisi[k] = "Cukup_Bagus";
                            }
                            else if (i == 0 && j == 2 && l == 0)
                            {
                                kondisi[k] = "Kurang_Bagus";
                            }
                            else if (i == 0 && j == 2 && l == 1)
                            {
                                kondisi[k] = "Cukup_Bagus";
                            }
                            else if (i == 0 && j == 2 && l == 2)
                            {
                                kondisi[k] = "Bagus";
                            }
                            else if (i == 1 && j == 0 && l == 0)
                            {
                                kondisi[k] = "Kurang_Bagus";
                            }
                            else if (i == 1 && j == 0 && l >= 1)
                            {
                                kondisi[k] = "Cukup_Bagus";
                            }
                            else if (i == 1 && j == 1 && l >= 0)
                            {
                                kondisi[k] = "Cukup_Bagus";
                            }
                            else if (i == 1 && j == 2 && l == 0)
                            {
                                kondisi[k] = "Cukup_Bagus";
                            }
                            else if (i == 1 && j == 2 && l >= 1)
                            {
                                kondisi[k] = "Bagus";
                            }
                            else if (i == 2 && j == 0 && l >= 0)
                            {
                                kondisi[k] = "Cukup_Bagus";
                            }
                            else if (i == 2 && j == 1 && l <= 1)
                            {
                                kondisi[k] = "Cukup_Bagus";
                            }
                            else if (i == 2 && j == 1 && l == 2)
                            {
                                kondisi[k] = "Bagus";
                            }
                            else if (i == 2 && j == 2 && l >= 0)
                            {
                                kondisi[k] = "Bagus";
                            }
                            else if (i == 3 && j == 0 && l >= 0)
                            {
                                kondisi[k] = "Cukup_Bagus";
                            }
                            else if (i == 3 && j == 1 && l == 0)
                            {
                                kondisi[k] = "Cukup_Bagus";
                            }
                            else if (i == 3 && j == 1 && l >= 1)
                            {
                                kondisi[k] = "Bagus";
                            }
                            else if (i == 3 && j == 2 && l == 0)
                            {
                                kondisi[k] = "Cukup Bagus";
                            }
                            else if (i == 3 && j == 2 && l >= 1)
                            {
                                kondisi[k] = "Bagus";
                            }

                            // .... //
                            Debug.Log("Ketika isi " + nilaiIsi[i] + ", penyampaian " + nilaiPenyampaian[j] + ", dan strategi " + nilaiStrategi[l] + ". Maka penilaian debat " + kondisi[k] + " dengan nilai = " + nilaiKondisi[k]);
                            k = k + 1;
                        }
                    }
                }
            }

            // Menentukan nilai max
            for (int i = 0; i < k; k++)
            {
                if (kondisi[i] == "Kurang Bagus")
                {
                    if (i == 0)
                    {
                        terbesarX = nilaiKondisi[i];
                    }
                    else if (nilaiKondisi[i] > terbesarX)
                    {
                        terbesarX = nilaiKondisi[i];
                    }
                }
                else if (kondisi[i] == "Cukup Bagus")
                {
                    if (i == 0)
                    {
                        terbesarY = nilaiKondisi[i];
                    }
                    else if (nilaiKondisi[i] > terbesarY)
                    {
                        terbesarY = nilaiKondisi[i];
                    }
                }
                else if (kondisi[i] == "Bagus")
                {
                    if (i == 0)
                    {
                        terbesarZ = nilaiKondisi[i];
                    }
                    else if (nilaiKondisi[i] > terbesarZ)
                    {
                        terbesarZ = nilaiKondisi[i];
                    }
                }
            }
            if (terbesarX > 0)
            {
                Debug.Log("Nilai penilaian debat kurang bagus = " + terbesarX);
            }
            if (terbesarY > 0)
            {
                Debug.Log("Nilai penilaian debat cukup bagus = " + terbesarY);
            }
            if (terbesarZ > 0)
            {
                Debug.Log("Nilai penilaian debat bagus = " + terbesarZ);
            }
        }

        // Bagian defuzzifikasi
        public float defuzzifikasi(float ambilSampel)
        {
            hasilPembilang = 0;
            pembilangX = 0;
            mirlangX = 0;
            pembilangY = 0;
            mirlangY = 0;
            pembilangZ = 0;
            mirlangZ = 0;
            pembilangmir = 0;
            hasilPenyebut = 0;
            hasilDefuzzifikasi = 0;
            titik_sampelX = 0;
            titik_sampelY = 0;
            titik_sampelZ = 0;
            jumlah_sampelX = 0;
            jumlah_sampelY = 0;
            jumlah_sampelZ = 0;
            jumlah_samir = 0;
            deltaX = 0;
            deltaY = 0;
            deltaZ = 0;
            k = 0;
            pengaliX = terbesarX;
            pengaliY = terbesarY;
            pengaliZ = terbesarZ;

            // Defuzzifikasi Kurang Bagus (Trapesium)
            if (terbesarX > 0)
            {
                deltaX = 63 / sampel;
                titik_sampelX = 0;
                Debug.Log("Nilai beda selisih = " + deltaX);
                Debug.Log("Nilai titik sampel diawal = " + titik_sampelX);
                for (int i = 1; i <= sampel; i++)
                {
                    if (titik_sampelX >= 0 && titik_sampelX <= 61)
                    {
                        pembilangX += titik_sampelX;
                        jumlah_sampelX += 1;
                        Debug.Log(i + ". Nilai pembilang = " + pembilangX);
                        Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_sampelX);
                    }
                    else if (titik_sampelX > 61 && titik_sampelX < 63)
                    {
                        mirlangX = ((63 - titik_sampelX) / 2);
                        Debug.Log(i + ". Nilai keanggotaan penilaian debat kurang bagus yang miring = " + mirlangX);
                        if (mirlangX >= terbesarX)
                        {
                            pembilangX += titik_sampelX;
                            jumlah_sampelX += 1;
                            Debug.Log(i + ". Nilai pembilang = " + pembilangX);
                            Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_sampelX);
                        }
                        else
                        {
                            pembilangmir += titik_sampelX * mirlangX;
                            jumlah_samir += mirlangX;
                            Debug.Log(i + ". Nilai pembilang miring = " + pembilangmir);
                            Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_samir);
                        }
                    }
                    Debug.Log("Sampel ke-" + i + " = " + titik_sampelX);
                    titik_sampelX += deltaX;
                    mirlangX = 0;
                }
            }

            // Defuzzifikasi Cukup Bagus (Trapesium)
            else if (terbesarY > 0)
            {
                deltaY = 15 / sampel;
                titik_sampelY = 61.01f;
                Debug.Log("Nilai beda selisih = " + deltaY);
                Debug.Log("Nilai titik sampel diawal = " + titik_sampelY);
                for (int i = 1; i <= sampel; i++)
                {
                    if (titik_sampelY > 61 && titik_sampelY < 63)
                    {
                        mirlangY = ((titik_sampelY - 61) / 2);
                        Debug.Log(i + ". Nilai keanggotaan penilaian debat cukup bagus yang miring = " + mirlangY);
                        if (mirlangY >= terbesarY)
                        {
                            pembilangY += titik_sampelY;
                            jumlah_sampelY += 1;
                            Debug.Log(i + ". Nilai pembilang = " + pembilangY);
                            Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_sampelY);
                        }
                        else
                        {
                            pembilangmir += titik_sampelY * mirlangY;
                            jumlah_samir += mirlangY;
                            Debug.Log(i + ". Nilai pembilang miring = " + pembilangmir);
                            Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_samir);
                        }
                    }
                    else if (titik_sampelY >= 63 && titik_sampelY <= 74)
                    {
                        pembilangY += titik_sampelY;
                        jumlah_sampelY += 1;
                        Debug.Log(i + ". Nilai pembilang = " + pembilangY);
                        Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_sampelY);
                    }
                    else if (titik_sampelY > 74 && titik_sampelY < 76)
                    {
                        mirlangY = ((76 - titik_sampelY) / 2);
                        Debug.Log(i + ". Nilai keanggotaan penilaian debat cukup bagus yang miring = " + mirlangY);
                        if (mirlangY >= terbesarY)
                        {
                            pembilangY += titik_sampelY;
                            jumlah_sampelY += 1;
                            Debug.Log(i + ". Nilai pembilang = " + pembilangY);
                            Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_sampelY);
                        }
                        else
                        {
                            pembilangmir += titik_sampelY * mirlangY;
                            jumlah_samir += mirlangY;
                            Debug.Log(i + ". Nilai pembilang miring = " + pembilangmir);
                            Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_samir);
                        }
                    }
                }
            }

            // Defuzzifikasi Bagus (Trapesium)
            else if (terbesarZ > 0)
            {
                deltaZ = 26 / sampel;
                titik_sampelZ = 74.01f;
                Debug.Log("Nilai beda selisih = " + deltaZ);
                Debug.Log("Nilai titik sampel diawal = " + titik_sampelZ);
                for (int i = 1; i <= sampel; i++)
                {
                    if (titik_sampelZ > 74 && titik_sampelZ < 76)
                    {
                        mirlangZ = ((titik_sampelZ - 74) / 2);
                        Debug.Log(i + ". Nilai keanggotaan penilaian debat bagus yang miring = " + mirlangZ);
                        if (mirlangZ >= terbesarZ)
                        {
                            pembilangZ += titik_sampelZ;
                            jumlah_sampelZ += 1;
                            Debug.Log(i + ". Nilai pembilang = " + pembilangZ);
                            Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_sampelZ);
                        }
                        else
                        {
                            pembilangmir += titik_sampelZ * mirlangZ;
                            jumlah_samir += mirlangZ;
                            Debug.Log(i + ". Nilai pembilang miring = " + pembilangmir);
                            Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_samir);
                        }
                    }
                    else if (titik_sampelZ >= 76 && titik_sampelZ <= 100)
                    {
                        pembilangZ += titik_sampelZ;
                        jumlah_sampelZ += 1;
                        Debug.Log(i + ". Nilai pembilang = " + pembilangZ);
                        Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_sampelZ);
                    }
                }
            }

            // Defuzzifikasi Kurang Bagus dan Cukup Bagus
            else if (terbesarX > 0 && terbesarY > 0 && terbesarZ == 0)
            {
                deltaX = 76 / sampel;
                titik_sampelX = 0;
                Debug.Log("Nilai beda selisih = " + deltaX);
                Debug.Log("Nilai titik sampel diawal = " + titik_sampelX);
                for (int i = 1; i <= sampel; i++)
                {
                    if (titik_sampelX >= 0 && titik_sampelX <= 61)
                    {
                        pembilangX += titik_sampelX;
                        jumlah_sampelX += 1;
                        Debug.Log(i + ". Nilai pembilang = " + pembilangX);
                        Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_sampelX);
                    }
                    else if (titik_sampelX > 61 && titik_sampelX < 63)
                    {
                        mirlangX = ((63 - titik_sampelX) / 2);
                        Debug.Log(i + ". Nilai keanggotaan penilaian debat kurang bagus yang miring = " + mirlangX);
                        mirlangX = ((titik_sampelX - 61) / 2);
                        Debug.Log(i + ". Nilai keanggotaan penilaian debat cukup bagus yang miring = " + mirlangY);
                        if (terbesarX <= terbesarY)
                        {
                            if (mirlangX >= terbesarX || terbesarX == terbesarY)
                            {
                                pembilangX += titik_sampelX;
                                jumlah_sampelX += 1;
                                Debug.Log(i + ". Nilai pembilang = " + pembilangX);
                                Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_sampelX);
                            }
                            else if (mirlangX < terbesarX)
                            {
                                pembilangmir += titik_sampelX * mirlangX;
                                jumlah_samir += mirlangX;
                                Debug.Log(i + ". Nilai pembilang miring = " + pembilangmir);
                                Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_samir);
                            }
                        }
                        else if (terbesarX > terbesarY)
                        {
                            if (mirlangY >= terbesarY)
                            {
                                pembilangY += titik_sampelX;
                                jumlah_sampelY += 1;
                                Debug.Log(i + ". Nilai pembilang = " + pembilangY);
                                Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_sampelY);
                            }
                            else if (mirlangY < terbesarY)
                            {
                                pembilangmir += titik_sampelX * mirlangY;
                                jumlah_samir += mirlangY;
                                Debug.Log(i + ". Nilai pembilang miring = " + pembilangmir);
                                Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_samir);
                            }
                        }
                    }
                    else if (titik_sampelX >= 63 && titik_sampelX <= 74)
                    {
                        pembilangY += titik_sampelX;
                        jumlah_sampelY += 1;
                        Debug.Log(i + ". Nilai pembilang = " + pembilangY);
                        Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_sampelY);
                    }
                    else if (titik_sampelX > 74 && titik_sampelX < 76)
                    {
                        mirlangY = ((76 - titik_sampelX) / 2);
                        Debug.Log(i + ". Nilai keanggotaan penilaian debat cukup bagus yang miring = " + mirlangY);
                        if (mirlangY >= terbesarY)
                        {
                            pembilangY += titik_sampelX;
                            jumlah_sampelY += 1;
                            Debug.Log(i + ". Nilai pembilang = " + pembilangY);
                            Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_sampelY);
                        }
                        else
                        {
                            pembilangmir += titik_sampelX * mirlangY;
                            jumlah_samir += mirlangY;
                            Debug.Log(i + ". Nilai pembilang miring = " + pembilangmir);
                            Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_samir);
                        }
                    }
                    Debug.Log("Sampel ke-" + i + " = " + titik_sampelX);
                    titik_sampelX += deltaX;
                    mirlangX = 0;
                    mirlangY = 0;
                }
            }

            // Defuzzifikasi Cukup Bagus dan Bagus
            else if (terbesarX == 0 && terbesarY > 0 && terbesarZ > 0)
            {
                deltaY = 76 / sampel;
                titik_sampelY = 61.01f;
                Debug.Log("Nilai beda selisih = " + deltaY);
                Debug.Log("Nilai titik sampel diawal = " + titik_sampelY);
                for (int i = 1; i <= sampel; i++)
                {
                    if (titik_sampelY > 61 && titik_sampelY < 63)
                    {
                        mirlangY = ((titik_sampelY - 61) / 2);
                        Debug.Log(i + ". Nilai keanggotaan penilaian debat cukup bagus yang miring = " + mirlangY);
                        if (mirlangY >= terbesarY)
                        {
                            pembilangY += titik_sampelY;
                            jumlah_sampelY += 1;
                            Debug.Log(i + ". Nilai pembilang = " + pembilangY);
                            Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_sampelY);
                        }
                        else
                        {
                            pembilangmir += titik_sampelY * mirlangY;
                            jumlah_samir += mirlangY;
                            Debug.Log(i + ". Nilai pembilang miring = " + pembilangmir);
                            Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_samir);
                        }
                    }
                    else if (titik_sampelY >= 63 && titik_sampelY <= 74)
                    {
                        pembilangY += titik_sampelY;
                        jumlah_sampelY += 1;
                        Debug.Log(i + ". Nilai pembilang = " + pembilangY);
                        Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_sampelY);
                    }
                    else if (titik_sampelY > 74 && titik_sampelY < 76)
                    {
                        mirlangY = ((76 - titik_sampelY) / 2);
                        Debug.Log(i + ". Nilai keanggotaan penilaian debat cukup bagus yang miring = " + mirlangY);
                        mirlangZ = ((titik_sampelY - 74) / 2);
                        Debug.Log(i + ". Nilai keanggotaan penilaian debat bagus yang miring = " + mirlangZ);
                        if (terbesarY <= terbesarZ)
                        {
                            if (mirlangY >= terbesarY || terbesarY == terbesarZ)
                            {
                                pembilangY += titik_sampelY;
                                jumlah_sampelY += 1;
                                Debug.Log(i + ". Nilai pembilang = " + pembilangY);
                                Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_sampelY);
                            }
                            else if (mirlangY < terbesarZ)
                            {
                                pembilangmir += titik_sampelY * mirlangY;
                                jumlah_samir += mirlangY;
                                Debug.Log(i + ". Nilai pembilang miring = " + pembilangmir);
                                Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_samir);
                            }
                        }
                        else if (terbesarY > terbesarZ)
                        {
                            if (mirlangZ >= terbesarZ)
                            {
                                pembilangZ += titik_sampelY;
                                jumlah_sampelZ += 1;
                                Debug.Log(i + ". Nilai pembilang = " + pembilangZ);
                                Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_sampelZ);
                            }
                            else if (mirlangZ < terbesarZ)
                            {
                                pembilangmir += titik_sampelY * mirlangZ;
                                jumlah_samir += mirlangZ;
                                Debug.Log(i + ". Nilai pembilang miring = " + pembilangmir);
                                Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_samir);
                            }
                        }
                    }
                    else if (titik_sampelY >= 76 && titik_sampelY <= 100)
                    {
                        pembilangZ += titik_sampelY;
                        jumlah_sampelZ += 1;
                        Debug.Log(i + ". Nilai pembilang = " + pembilangZ);
                        Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_sampelZ);
                    }
                    Debug.Log("Sampel ke-" + i + " = " + titik_sampelY);
                    titik_sampelY += deltaY;
                    mirlangY = 0;
                    mirlangZ = 0;
                }
            }

            // Defuzzifikasi Kurang Bagus, Cukup Bagus, dan Bagus
            else if (terbesarX > 0 && terbesarY > 0 && terbesarZ > 0)
            {
                deltaZ = 100 / sampel;
                titik_sampelZ = 0;
                Debug.Log("Nilai beda selisih = " + deltaZ);
                Debug.Log("Nilai titik sampel diawal = " + titik_sampelZ);
                for (int i = 1; i <= sampel; i++)
                {
                    if (titik_sampelZ >= 0 && titik_sampelZ <= 61)
                    {
                        pembilangX += titik_sampelZ;
                        jumlah_sampelX += 1;
                        Debug.Log(i + ". Nilai pembilang = " + pembilangX);
                        Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_sampelX);
                    }
                    else if (titik_sampelZ > 61 && titik_sampelZ < 63)
                    {
                        mirlangX = ((63 - titik_sampelZ) / 2);
                        Debug.Log(i + ". Nilai keanggotaan penilaian debat kurang bagus yang miring = " + mirlangX);
                        mirlangX = ((titik_sampelZ - 61) / 2);
                        Debug.Log(i + ". Nilai keanggotaan penilaian debat cukup bagus yang miring = " + mirlangY);
                        if (terbesarX <= terbesarY)
                        {
                            if (mirlangX >= terbesarX || terbesarX == terbesarY)
                            {
                                pembilangX += titik_sampelZ;
                                jumlah_sampelX += 1;
                                Debug.Log(i + ". Nilai pembilang = " + pembilangX);
                                Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_sampelX);
                            }
                            else if (mirlangX < terbesarX)
                            {
                                pembilangmir += titik_sampelZ * mirlangX;
                                jumlah_samir += mirlangX;
                                Debug.Log(i + ". Nilai pembilang miring = " + pembilangmir);
                                Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_samir);
                            }
                        }
                        else if (terbesarX > terbesarY)
                        {
                            if (mirlangY >= terbesarY)
                            {
                                pembilangY += titik_sampelZ;
                                jumlah_sampelY += 1;
                                Debug.Log(i + ". Nilai pembilang = " + pembilangY);
                                Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_sampelY);
                            }
                            else if (mirlangY < terbesarY)
                            {
                                pembilangmir += titik_sampelZ * mirlangY;
                                jumlah_samir += mirlangY;
                                Debug.Log(i + ". Nilai pembilang miring = " + pembilangmir);
                                Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_samir);
                            }
                        }
                    }
                    else if (titik_sampelZ >= 63 && titik_sampelZ <= 74)
                    {
                        pembilangY += titik_sampelZ;
                        jumlah_sampelY += 1;
                        Debug.Log(i + ". Nilai pembilang = " + pembilangY);
                        Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_sampelY);
                    }
                    else if (titik_sampelZ > 74 && titik_sampelZ < 76)
                    {
                        mirlangY = ((76 - titik_sampelZ) / 2);
                        Debug.Log(i + ". Nilai keanggotaan penilaian debat cukup bagus yang miring = " + mirlangY);
                        mirlangZ = ((titik_sampelZ - 74) / 2);
                        Debug.Log(i + ". Nilai keanggotaan penilaian debat bagus yang miring = " + mirlangZ);
                        if (terbesarY <= terbesarZ)
                        {
                            if (mirlangY >= terbesarY || terbesarY == terbesarZ)
                            {
                                pembilangY += titik_sampelZ;
                                jumlah_sampelY += 1;
                                Debug.Log(i + ". Nilai pembilang = " + pembilangY);
                                Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_sampelY);
                            }
                            else if (mirlangY < terbesarZ)
                            {
                                pembilangmir += titik_sampelZ * mirlangY;
                                jumlah_samir += mirlangY;
                                Debug.Log(i + ". Nilai pembilang miring = " + pembilangmir);
                                Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_samir);
                            }
                        }
                        else if (terbesarY > terbesarZ)
                        {
                            if (mirlangZ >= terbesarZ)
                            {
                                pembilangZ += titik_sampelZ;
                                jumlah_sampelZ += 1;
                                Debug.Log(i + ". Nilai pembilang = " + pembilangZ);
                                Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_sampelZ);
                            }
                            else if (mirlangZ < terbesarZ)
                            {
                                pembilangmir += titik_sampelZ * mirlangZ;
                                jumlah_samir += mirlangZ;
                                Debug.Log(i + ". Nilai pembilang miring = " + pembilangmir);
                                Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_samir);
                            }
                        }
                    }
                    else if (titik_sampelZ >= 76 && titik_sampelZ <= 100)
                    {
                        pembilangZ += titik_sampelZ;
                        jumlah_sampelZ += 1;
                        Debug.Log(i + ". Nilai pembilang = " + pembilangZ);
                        Debug.Log(i + ". Nilai jumlah sampel = " + jumlah_sampelZ);
                    }
                    Debug.Log("Sampel ke-" + i + " = " + titik_sampelZ);
                    titik_sampelZ += deltaZ;
                    mirlangX = 0;
                    mirlangY = 0;
                    mirlangZ = 0;
                }
            }
            hasilPembilang = (pembilangX * pengaliX) + pembilangmir + (pembilangY * pengaliY) + (pembilangZ * pengaliZ);
            hasilPenyebut = (jumlah_sampelX * pengaliX) + jumlah_samir + (jumlah_sampelY * pengaliY) + (jumlah_sampelZ * pengaliZ);
            Debug.Log("Hasil pembilang = " + hasilPembilang);
            Debug.Log("Hasil penyebut = " + hasilPenyebut);
            hasilDefuzzifikasi = hasilPembilang / hasilPenyebut;
            Debug.Log("Hasil defuzzifikasi = " + hasilDefuzzifikasi);
            return hasilDefuzzifikasi;
        }

        public void cetakMember()
        {
            Debug.Log("Nilai Fuzzy isi dengan input " + isi);
            Debug.Log("Isi kurang bagus adalah " + memberIsiKurangBagus);
            Debug.Log("Isi cukup bagus adalah " + memberIsiCukupBagus);
            Debug.Log("Isi bagus adalah " + memberIsiBagus);
            Debug.Log("Isi bagus sekali adalah " + memberIsiBagusSekali);
            Debug.Log("Nilai Fuzzy penyampaian dengan input " + penyampaian);
            Debug.Log("Penyampaian kurang bagus adalah " + memberPenyampaianKurangBagus);
            Debug.Log("Penyampaian cukup bagus adalah " + memberPenyampaianCukupBagus);
            Debug.Log("Penyampaian bagus adalah " + memberPenyampaianBagus);
            Debug.Log("Nilai Fuzzy strategi dengan input " + strategi);
            Debug.Log("Strategi kurang bagus adalah " + memberStrategiKurangBagus);
            Debug.Log("Strategi cukup bagus adalah " + memberStrategiCukupBagus);
            Debug.Log("Strategi bagus adalah " + memberStrategiBagus);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        metodeFuzzyMamdani();
    }

    public void metodeFuzzyMamdani()
    {
        // inisialisasi nilai isi, penyampaian, strategi
        isi = 24;
        Debug.Log("Nilai Isi: " + isi);
        penyampaian = 25;
        Debug.Log("Nilai Penyampaian: " + penyampaian);
        strategi = 3;
        Debug.Log("Nilai Strategi: " + strategi);
        // Masuk tahap Fuzzifikasi
        fuzzy_mamdani fuzzy = new fuzzy_mamdani();
        fuzzy.anggotaisi(isi);
        fuzzy.anggotapenyampaian(penyampaian);
        fuzzy.anggotastrategi(strategi);
        fuzzy.cetakMember();
        // Masuk tahap Inferensi
        fuzzy.inferensi();
        // Masuk tahap Defuzzifikasi
        sampel = 10;
        na = fuzzy.defuzzifikasi(sampel);
        Debug.Log("Nilai Akhir = " + na);
        hasilkeluaran = (int)na;
        Debug.Log("Nilai Keluaran = " + hasilkeluaran);
        if (na - hasilkeluaran >= 0.5)
        {
            hasilkeluaran += 1;
        }
        else hasilkeluaran += 0;
        Debug.Log("Skor Penilaian Debat adalah  = " + hasilkeluaran);
    }

    public void hapusinputfuzzy()
    {

    }
}
