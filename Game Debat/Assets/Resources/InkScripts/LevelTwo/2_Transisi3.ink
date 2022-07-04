EXTERNAL Name(charName)
EXTERNAL Icon(charName)
EXTERNAL CharAnimation(charName, animationName)
EXTERNAL ChangeTime(timeLeft)
EXTERNAL ShowArgue(argueStatus)
EXTERNAL ChangeScript(scriptName)
EXTERNAL AddDebateScoreIsi(debateScoreIsi)
EXTERNAL AddDebateScoreStrategi(debateScoreStrategi)
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
{AddDebateScoreIsi(13)}
{AddDebateScoreStrategi(1)}
{ChangeScript("2_Argumen3_1")}

* [Belajar Menggunakan Media Sosial]
{AddDebateScoreIsi(11)}
{AddDebateScoreStrategi(1)}
{ChangeScript("2_Argumen3_2")}

* [(Batal Menginterupsi)]
{AddDebateScoreIsi(0)}
{AddDebateScoreStrategi(0)}
{ChangeScript("2_Argumen3_3")}