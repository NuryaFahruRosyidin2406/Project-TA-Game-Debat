EXTERNAL Name(charName)
EXTERNAL Icon(charName)
EXTERNAL CharAnimation(charName, animationName)
EXTERNAL ChangeTime(timeLeft)
EXTERNAL ShowArgue(argueStatus)
EXTERNAL ChangeScript(scriptName)
EXTERNAL ChoiceTime(timeLeft)

{ChangeTime(0)}
test 

{Name("Pemain")}
{Icon("pemain")}
{CharAnimation("haru_greeter_t03","Listening")}
{ChoiceTime(10)}
{ChangeTime(2)}
{ShowArgue(false)}
(Pilih argumen sanggahan untuk membantah argumen lawan!)

* [Mengajarkan Manajemen Waktu]
{ChangeScript("2_Argumen3_1")}

* [Belajar Menggunakan Media Sosial]
{ChangeScript("2_Argumen3_2")}

* [(Batal Menginterupsi)]
{ChangeScript("2_Argumen3_3")}