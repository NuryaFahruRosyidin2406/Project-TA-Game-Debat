EXTERNAL Name(charName)
EXTERNAL Icon(charName)
EXTERNAL CharAnimation(charName, animationName)
EXTERNAL CharExpression(charName, expressionInt)
EXTERNAL ChangeTime(timeLeft)
EXTERNAL ShowArgue(argueStatus)
EXTERNAL ChangeScript(scriptName)
EXTERNAL TransNum(transNumber)
EXTERNAL ChoiceTime(timeLeft)
EXTERNAL DebateStatus(debateStatus)

{ChangeTime(0)}
Baiklah, waktu penyampaian argumen sudah habis.

{Name("Moderator")}
{Icon("mc1")}
{ChangeTime(3)}
{DebateStatus(false)}
Berhenti!

{Name("Moderator")}
{Icon("mc1")}
{ChangeTime(3)}
Waktu anda sudah habis.

{ChangeScript("3_Penutup")}