EXTERNAL Name(charName)
EXTERNAL Icon(charName)
EXTERNAL CharAnimation(charName, animationName)
EXTERNAL CharExpression(charName, expressionInt)
EXTERNAL ChangeTime(timeLeft)
EXTERNAL ShowArgue(argueStatus)
EXTERNAL ChangeScript(scriptName)
EXTERNAL ChoiceTime(timeLeft)
EXTERNAL AddDebateScore(debateScore)

{ChangeTime(0)}
Test

{Name("Pemain")}
{Icon("pemain")}
{ChangeTime(5)}
Tentunya universitas di negara ini memiliki kriteria tertentu kepada calon mahasiswa, salah satunya nilai UN.

{ChangeTime(5)}
Dalam hal ini, nilai UN memiliki manfaat dalam seleksi masuk jenjang pendidikan yang lebih tinggi atau berikutnya.

{ChangeTime(3)}
Akan tetapi, bukan berarti hal tersebut tidak dapat untuk diminimalisasi. 

{ChangeTime(4)}
Ujian Nasional masih sangat penting terutama di Indonesia.

{ChangeTime(5)}
UN dapat menjadi standar nasional yang seragam antara satu sekolah dengan sekolah lainnya.

{ChangeTime(3)}
Selain itu, Ujian nasional akan memotivasi siswa untuk lebih giat belajar

{ChangeTime(5)}
Demi mencapai cita-citanya, yaitu masuk ke sekolah favorit yang diidamkan.

{Name("Fatih")}
{Icon("fatih")}
{CharAnimation("chitose","AgreeWithYou")}
{CharExpression("chitose",0)}
{ChangeTime(4)}
Persiapan Ujian Masuk Sekolah Baru Bisa Dilakukan Tanpa UN

{Name("Pemain")}
{Icon("pemain")}
{ChoiceTime(1000)}
{ChangeTime(2)}
Pilih untuk mempertahankan argumen! 

* [UN Sebagai Sarana Persiapan]
{AddDebateScore(5)}
{Name("Pemain")}
{Icon("pemain")}
{CharAnimation("chitose","AgreeWithYou")}
{CharExpression("chitose",1)}
{ChangeTime(3)}
Memang benar persiapan bisa dilakukan tanpa UN.

{ChangeTime(5)}
UN dapat menjadi media persiapan yang mematangkan potensi untuk belajar dan mengukur diri.

{ChangeScript("2_Transisi1_3")}

* [UN Adalah Syarat Wajib]
{AddDebateScore(-5)}
{Name("Pemain")}
{Icon("pemain")}
{CharAnimation("chitose","AgreeWithYou")}
{CharExpression("chitose",1)}
{ChangeTime(5)}
Saya tidak setuju! Karena nyatanya UN adalah standar nilai yang digunakan untuk seleksi masuk sekolah baru

{ChangeTime(4)}
Dan secara otomatis persiapan UN sama dengan persiapan Ujian Masuk.

{ChangeScript("2_Transisi1_3")}