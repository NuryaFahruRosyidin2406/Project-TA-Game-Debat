EXTERNAL Name(charName)
EXTERNAL Icon(charName)
EXTERNAL CharAnimation(charName, animationName)
EXTERNAL CharExpression(charName, expressionInt)
EXTERNAL ChangeTime(timeLeft)
EXTERNAL ShowArgue(argueStatus)
EXTERNAL ChangeScript(scriptName)
EXTERNAL ChoiceTime(timeLeft)

{ChangeTime(0)}
Test

{Name("Pemain")}
{Icon("pemain")}
{CharAnimation("chitose","GivinganArgument")}
{CharExpression("chitose",5)}
{ChangeTime(5)}
Universitas di Indonesia memiliki kriteria tertentu terhadap calon mahasiswa, salah satunya nilai ujian nasional.

{ChangeTime(5)}
Dalam hal ini, nilai ujian nasional bermanfaat dalam seleksi masuk jenjang pendidikan yang lebih tinggi atau berikutnya.

{CharAnimation("chitose","AgreeWithYou")}
{CharExpression("chitose",0)}
{ChangeTime(3)}
Akan tetapi, bukan berarti hal tersebut tidak dapat diminimalisasi. 

{ChangeTime(6)}
Ujian Nasional masih sangat penting terutama di Indonesia karena Ujian Nasional dapat menjadi standar nasional yang seragam antara satu sekolah dengan sekolah lainnya.

{CharAnimation("chitose","GivinganArgument")}
{ChangeTime(3)}
Selain itu, Ujian Nasional juga masih tetap dibutuhkan. 

{ChangeTime(5)}
Selain itu, Ujian nasional akan memotivasi siswa untuk lebih giat belajar demi mencapai cita-citanya, yaitu masuk ke sekolah favorit yang diidamkan.

{Name("Fatih")}
{Icon("fatih")}
{CharAnimation("chitose","AgreeWithYou")}
{CharExpression("chitose",1)}
{ChangeTime(4)}
Persiapan Ujian Masuk Sekolah Baru Bisa Dilakukan Tanpa UN

{Name("Pemain")}
{Icon("pemain")}
{ChoiceTime(1000)}
{ChangeTime(2)}
Pilih untuk mempertahankan argumen! 

* [UN Sebagai Sarana Persiapan]
{Name("Pemain")}
{Icon("pemain")}
{CharAnimation("chitose","AgreeWithYou")}
{CharExpression("chitose",1)}
{ChangeTime(3)}
Memang benar persiapan bisa dilakukan tanpa UN.

{ChangeTime(5)}
Namun dengan adanya UN, hal ini dapat menjadi media persiapan yang mematangkan potensi siswa untuk belajar dan mengukur diri mereka

{ChangeScript("2_Transisi1_3")}

* [UN Adalah Syarat Wajib]
{Name("Pemain")}
{Icon("pemain")}
{CharAnimation("chitose","AgreeWithYou")}
{CharExpression("chitose",1)}
{ChangeTime(5)}
Saya tidak setuju! Karena nyatanya UN adalah standar nilai yang digunakan untuk seleksi masuk sekolah baru

{ChangeTime(4)}
dan secara otomatis mempersiapkan UN sama dengan mempersiapkan Ujian Masuk

{ChangeScript("2_Transisi1_3")}