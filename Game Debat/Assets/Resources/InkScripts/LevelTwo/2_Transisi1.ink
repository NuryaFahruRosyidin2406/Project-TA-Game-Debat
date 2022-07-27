EXTERNAL Name(charName)
EXTERNAL Icon(charName)
EXTERNAL CharAnimation(charName, animationName)
EXTERNAL ChangeTime(timeLeft)
EXTERNAL ShowArgue(argueStatus)
EXTERNAL ChangeScript(scriptName)
EXTERNAL ChoiceTime(timeLeft)
EXTERNAL AddDebateScoreIsi(debateScoreIsi)
EXTERNAL AddDebateScoreStrategi(debateScoreStrategi)
EXTERNAL ChangeChoiceTime(changeTime)

{ChangeTime(0)}
test 

{Name("Budi")}
{Icon("pemain")}
{CharAnimation("haru_greeter_t03","Listening")}
{ChoiceTime(10)}
{ChangeTime(2)}
{ShowArgue(false)}
(Pilih argumen sanggahan untuk membantah argumen lawan!)

* [Media Sosial Melatih Interaksi Sosial]
{ChangeChoiceTime(-2)}
{AddDebateScoreIsi(13)}
{AddDebateScoreStrategi(1)}
{ChangeScript("2_Argumen1_1")}

* [Membatasi Penggunaan Media Sosial]
{ChangeChoiceTime(2)}
{AddDebateScoreIsi(12)}
{AddDebateScoreStrategi(1)}
{ChangeScript("2_Argumen1_2")}

* [(Batal Menginterupsi)]
{AddDebateScoreIsi(0)}
{AddDebateScoreStrategi(0)}
{ChangeScript("2_Argumen1_3")}