EXTERNAL Name(charName)
EXTERNAL Icon(charName)
EXTERNAL CharAnimation(charName, animationName)
EXTERNAL ChangeTime(timeLeft)
EXTERNAL ShowArgue(argueStatus)
EXTERNAL ChangeScript(scriptName)
EXTERNAL TransNum(transNumber)

{ChangeTime(0)}
Test

{Name("Farah")}
{Icon("farah")}
{CharAnimation("haru_greeter_t03","GivingArgument")}
{ChangeTime(5)}
Memang kecanduan terhadap media sosial dapat diatasi dengan penerapan aturan yang tegas.

{CharAnimation("haru_greeter_t03","Listening")}
{ChangeTime(5)}
Akan tetapi, apakah Anda yakin aturan tersebut benar-benar akan berjalan sesuai harapan?

{ChangeTime(5)}
Saya beranggapan bahwa penggunaan media sosial di lingkungan sekolah tidak membawa dampak yang baik.

{CharAnimation("haru_greeter_t03","ShakeHead")}
{ChangeTime(6)}
Karena para pelajar tersebut akan fokus pada dunia maya dan melupakan tujuan awal mereka menggunakan media sosial.

{ChangeTime(4)}
Selain itu, media sosial juga dapat menimbulkan kecanduan.

{CharAnimation("haru_greeter_t03","Listening")}
{ChangeTime(3)}
Para siswa akan merasa gelisah ketika tidak mengakses media sosial.

{ChangeTime(3)}
Pada akhirnya mereka akan sibuk dengan media sosial dan mulai lupa waktu,

{ShowArgue(true)}
{TransNum(3)}
{CharAnimation("haru_greeter_t03","ShakeHead")}
{ChangeTime(4)}
Sehingga mereka melupakan tugas utama, yaitu belajar.

{ShowArgue(false)}
{ChangeScript("3_Penutup")}