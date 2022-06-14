EXTERNAL Name(charName)
EXTERNAL Icon(charName)
EXTERNAL CharAnimation(charName, animationName)
EXTERNAL ChangeTime(timeLeft)
EXTERNAL ShowArgue(argueStatus)
EXTERNAL ChangeScript(scriptName)
EXTERNAL TransNum(transNumber)
EXTERNAL ChoiceTime(timeLeft)
EXTERNAL AddDebateScore(debateScore)

{ChangeTime(0)}
Baiklah, waktu penyampaian argumen sudah habis.

{Name("Moderator")}
{Icon("mc2")}
{ChangeTime(3)}
{AddDebateScore(-5)}
Berhenti!

{Name("Moderator")}
{Icon("mc2")}
{ChangeTime(3)}
Waktu anda sudah habis.

{ChangeScript("3_Penutup")}