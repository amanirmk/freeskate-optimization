using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
public class masterscript : MonoBehaviour
{
private int frameCount = 0;
public static GameObject leftskate;
public static GameObject rightskate;
public static GameObject forceline;
public static GameObject moveline;
static GameObject skate0;
static GameObject forceline0;
static GameObject moveline0;
static GameObject skate1;
static GameObject forceline1;
static GameObject moveline1;
public interface frame
{
void visualize();
}
public class frame0 : frame
{
public void visualize()
{
skate0 = Instantiate(leftskate,new Vector3(0f,0f,0f),Quaternion.Euler(0,45.0f, 0));
skate1 = Instantiate(rightskate,new Vector3(2.5f,0f,0f),Quaternion.Euler(0,135.0f, 0));
}
}
public class frame1 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.00017857142857142857f,0f,0.00017857142857142854f);
skate0.transform.rotation = Quaternion.Euler(0,45.1432394487827f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.00017857142857142857f,0f,0.00017857142857142854f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.2f);
moveline0 = Instantiate(moveline,new Vector3(-0.00017857142857142857f,0f,0.00017857142857142854f),Quaternion.Euler(0,-135.0f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.1414213562373095f);
skate1.transform.position = new Vector3(2.4998214285714284f,0f,-0.00017857142857142854f);
skate1.transform.rotation = Quaternion.Euler(0,134.8567605512173f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.4998214285714284f,0f,-0.00017857142857142854f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.2f);
moveline1 = Instantiate(moveline,new Vector3(2.4998214285714284f,0f,-0.00017857142857142854f),Quaternion.Euler(0,-45.0f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.1414213562373095f);
}
}
public class frame2 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.0005357449866962885f,0f,0.0005348542011565666f);
skate0.transform.rotation = Quaternion.Euler(0,45.42971834634812f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.0005357449866962885f,0f,0.0005348542011565666f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.20003688555570326f);
moveline0 = Instantiate(moveline,new Vector3(-0.0005357449866962885f,0f,0.0005348542011565666f),Quaternion.Euler(0,-135.1432394487827f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.14180061446816788f);
skate1.transform.position = new Vector3(2.4994642550133035f,0f,-0.0005348542011565666f);
skate1.transform.rotation = Quaternion.Euler(0,134.57028165365188f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.4994642550133035f,0f,-0.0005348542011565666f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.20003688555570326f);
moveline1 = Instantiate(moveline,new Vector3(2.4994642550133035f,0f,-0.0005348542011565666f),Quaternion.Euler(0,-44.85676055121729f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.14180061446816788f);
}
}
public class frame3 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.0010715685153592043f,0f,0.0010671270937284401f);
skate0.transform.rotation = Quaternion.Euler(0,45.85943669269623f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.0010715685153592043f,0f,0.0010671270937284401f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.20011047900940643f);
moveline0 = Instantiate(moveline,new Vector3(-0.0010715685153592043f,0f,0.0010671270937284401f),Quaternion.Euler(0,-135.42971834634812f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.14255673316596354f);
skate1.transform.position = new Vector3(2.4989284314846407f,0f,-0.0010671270937284401f);
skate1.transform.rotation = Quaternion.Euler(0,134.14056330730378f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.4989284314846407f,0f,-0.0010671270937284401f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.20011047900940643f);
moveline1 = Instantiate(moveline,new Vector3(2.4989284314846407f,0f,-0.0010671270937284401f),Quaternion.Euler(0,-44.570281653651875f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.14255673316596354f);
}
}
public class frame4 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.001786079840804329f,0f,0.0017728059800828835f);
skate0.transform.rotation = Quaternion.Euler(0,46.432394487827054f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.001786079840804329f,0f,0.0017728059800828835f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.20022042483001073f);
moveline0 = Instantiate(moveline,new Vector3(-0.001786079840804329f,0f,0.0017728059800828835f),Quaternion.Euler(0,-135.85943669269625f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.1436848716563745f);
skate1.transform.position = new Vector3(2.4982139201591957f,0f,-0.0017728059800828835f);
skate1.transform.rotation = Quaternion.Euler(0,133.56760551217295f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.4982139201591957f,0f,-0.0017728059800828835f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.20022042483001073f);
moveline1 = Instantiate(moveline,new Vector3(2.4982139201591957f,0f,-0.0017728059800828835f),Quaternion.Euler(0,-44.14056330730375f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.1436848716563745f);
}
}
public class frame5 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.0026792659731163897f,0f,0.0026484420571198106f);
skate0.transform.rotation = Quaternion.Euler(0,47.14859173174058f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.0026792659731163897f,0f,0.0026484420571198106f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.2003661892531876f);
moveline0 = Instantiate(moveline,new Vector3(-0.0026792659731163897f,0f,0.0026484420571198106f),Quaternion.Euler(0,-136.43239448782705f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.14517765668737487f);
skate1.transform.position = new Vector3(2.4973207340268835f,0f,-0.0026484420571198106f);
skate1.transform.rotation = Quaternion.Euler(0,132.85140826825943f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.4973207340268835f,0f,-0.0026484420571198106f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.2003661892531876f);
moveline1 = Instantiate(moveline,new Vector3(2.4973207340268835f,0f,-0.0026484420571198106f),Quaternion.Euler(0,-43.567605512172946f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.14517765668737487f);
}
}
public class frame6 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.0037510086104805282f,0f,0.0036897211050733007f);
skate0.transform.rotation = Quaternion.Euler(0,48.008028424436816f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.0037510086104805282f,0f,0.0036897211050733007f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.20054705992082694f);
moveline0 = Instantiate(moveline,new Vector3(-0.0037510086104805282f,0f,0.0036897211050733007f),Quaternion.Euler(0,-137.14859173174057f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.1470250495225961f);
skate1.transform.position = new Vector3(2.4962489913895194f,0f,-0.0036897211050733007f);
skate1.transform.rotation = Quaternion.Euler(0,131.99197157556318f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.4962489913895194f,0f,-0.0036897211050733007f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.20054705992082694f);
moveline1 = Instantiate(moveline,new Vector3(2.4962489913895194f,0f,-0.0036897211050733007f),Quaternion.Euler(0,-42.85140826825943f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.1470250495225961f);
}
}
public class frame7 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.005001015945001347f,0f,0.004891465183056289f);
skate0.transform.rotation = Quaternion.Euler(0,49.01070456591575f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.005001015945001347f,0f,0.004891465183056289f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.20076214573559753f);
moveline0 = Instantiate(moveline,new Vector3(-0.005001015945001347f,0f,0.004891465183056289f),Quaternion.Euler(0,-138.00802842443682f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.1492141717920311f);
skate1.transform.position = new Vector3(2.4949989840549986f,0f,-0.004891465183056289f);
skate1.transform.rotation = Quaternion.Euler(0,130.98929543408426f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.4949989840549986f,0f,-0.004891465183056289f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.20076214573559753f);
moveline1 = Instantiate(moveline,new Vector3(2.4949989840549986f,0f,-0.004891465183056289f),Quaternion.Euler(0,-41.991971575563184f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.1492141717920311f);
}
}
public class frame8 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.00642874086070727f,0f,0.006247638513812787f);
skate0.transform.rotation = Quaternion.Euler(0,50.156620156177404f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.00642874086070727f,0f,0.006247638513812787f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.20101037721932916f);
moveline0 = Instantiate(moveline,new Vector3(-0.00642874086070727f,0f,0.006247638513812787f),Quaternion.Euler(0,-139.01070456591574f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.1517290928984408f);
skate1.transform.position = new Vector3(2.493571259139293f,0f,-0.006247638513812787f);
skate1.transform.rotation = Quaternion.Euler(0,129.8433798438226f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.493571259139293f,0f,-0.006247638513812787f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.20101037721932916f);
moveline1 = Instantiate(moveline,new Vector3(2.493571259139293f,0f,-0.006247638513812787f),Quaternion.Euler(0,-40.989295434084255f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.1517290928984408f);
}
}
public class frame9 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.008033285773248036f,0f,0.007751359660642554f);
skate0.transform.rotation = Quaternion.Euler(0,51.44577519522175f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.008033285773248036f,0f,0.007751359660642554f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.2012905077368575f);
moveline0 = Instantiate(moveline,new Vector3(-0.008033285773248036f,0f,0.007751359660642554f),Quaternion.Euler(0,-140.1566201561774f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.15455058268982497f);
skate1.transform.position = new Vector3(2.491966714226752f,0f,-0.007751359660642554f);
skate1.transform.rotation = Quaternion.Euler(0,128.55422480477824f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.491966714226752f,0f,-0.007751359660642554f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.2012905077368575f);
moveline1 = Instantiate(moveline,new Vector3(2.491966714226752f,0f,-0.007751359660642554f),Quaternion.Euler(0,-39.84337984382259f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.15455058268982497f);
}
}
public class frame10 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.00981329459639046f,0f,0.009394922436420811f);
skate0.transform.rotation = Quaternion.Euler(0,52.87816968304881f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.00981329459639046f,0f,0.009394922436420811f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.2016011160190116f);
moveline0 = Instantiate(moveline,new Vector3(-0.00981329459639046f,0f,0.009394922436420811f),Quaternion.Euler(0,-141.44577519522176f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.15765583414967196f);
skate1.transform.position = new Vector3(2.4901867054036098f,0f,-0.009394922436420811f);
skate1.transform.rotation = Quaternion.Euler(0,127.12183031695119f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.4901867054036098f,0f,-0.009394922436420811f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.2016011160190116f);
moveline1 = Instantiate(moveline,new Vector3(2.4901867054036098f,0f,-0.009394922436420811f),Quaternion.Euler(0,-38.554224804778244f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.15765583414967196f);
}
}
public class frame11 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.011766832644495458f,0f,0.011169828298148122f);
skate0.transform.rotation = Quaternion.Euler(0,54.45380361965857f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.011766832644495458f,0f,0.011169828298148122f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.20194061048800488f);
moveline0 = Instantiate(moveline,new Vector3(-0.011766832644495458f,0f,0.011169828298148122f),Quaternion.Euler(0,-142.87816968304884f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.16101816203989888f);
skate1.transform.position = new Vector3(2.4882331673555047f,0f,-0.011169828298148122f);
skate1.transform.rotation = Quaternion.Euler(0,125.54619638034143f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.4882331673555047f,0f,-0.011169828298148122f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.20194061048800488f);
moveline1 = Instantiate(moveline,new Vector3(2.4882331673555047f,0f,-0.011169828298148122f),Quaternion.Euler(0,-37.12183031695119f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.16101816203989888f);
}
}
public class frame12 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.013891255702970087f,0f,0.013066833255008271f);
skate0.transform.rotation = Quaternion.Euler(0,56.17267700505104f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.013891255702970087f,0f,0.013066833255008271f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.2023072359532722f);
moveline0 = Instantiate(moveline,new Vector3(-0.013891255702970087f,0f,0.013066833255008271f),Quaternion.Euler(0,-144.45380361965857f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.16460668476027845f);
skate1.transform.position = new Vector3(2.48610874429703f,0f,-0.013066833255008271f);
skate1.transform.rotation = Quaternion.Euler(0,123.82732299494896f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.48610874429703f,0f,-0.013066833255008271f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.2023072359532722f);
moveline1 = Instantiate(moveline,new Vector3(2.48610874429703f,0f,-0.013066833255008271f),Quaternion.Euler(0,-35.546196380341414f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.16460668476027845f);
}
}
public class frame13 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.016183070028026266f,0f,0.015076012533363832f);
skate0.transform.rotation = Quaternion.Euler(0,58.03478983922622f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.016183070028026266f,0f,0.015076012533363832f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.20269908330258915f);
moveline0 = Instantiate(moveline,new Vector3(-0.016183070028026266f,0f,0.015076012533363832f),Quaternion.Euler(0,-146.17267700505107f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.16838599815564398f);
skate1.transform.position = new Vector3(2.4838169299719737f,0f,-0.015076012533363832f);
skate1.transform.rotation = Quaternion.Euler(0,121.96521016077378f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.4838169299719737f,0f,-0.015076012533363832f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.20269908330258915f);
moveline1 = Instantiate(moveline,new Vector3(2.4838169299719737f,0f,-0.015076012533363832f),Quaternion.Euler(0,-33.82732299494896f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.16838599815564398f);
}
}
public class frame14 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.018637785677074185f,0f,0.01718684637354921f);
skate0.transform.rotation = Quaternion.Euler(0,60.0401421221841f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.018637785677074185f,0f,0.01718684637354921f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.20311410285795217f);
moveline0 = Instantiate(moveline,new Vector3(-0.018637785677074185f,0f,0.01718684637354921f),Quaternion.Euler(0,-148.03478983922622f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.1723158515877195f);
skate1.transform.position = new Vector3(2.481362214322926f,0f,-0.01718684637354921f);
skate1.transform.rotation = Quaternion.Euler(0,119.95985787781589f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.481362214322926f,0f,-0.01718684637354921f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.20311410285795217f);
moveline1 = Instantiate(moveline,new Vector3(2.481362214322926f,0f,-0.01718684637354921f),Quaternion.Euler(0,-31.965210160773765f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.1723158515877195f);
}
}
public class frame15 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.02124976632073585f,0f,0.01938833035105341f);
skate0.transform.rotation = Quaternion.Euler(0,62.18873385392469f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.02124976632073585f,0f,0.01938833035105341f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.2035501220930585f);
moveline0 = Instantiate(moveline,new Vector3(-0.02124976632073585f,0f,0.01938833035105341f),Quaternion.Euler(0,-150.0401421221841f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.1763508382556203f);
skate1.transform.position = new Vector3(2.478750233679264f,0f,-0.01938833035105341f);
skate1.transform.rotation = Quaternion.Euler(0,117.81126614607531f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.478750233679264f,0f,-0.01938833035105341f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.2035501220930585f);
moveline1 = Instantiate(moveline,new Vector3(2.478750233679264f,0f,-0.01938833035105341f),Quaternion.Euler(0,-29.959857877815878f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.1763508382556203f);
}
}
public class frame16 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.024012079538965676f,0f,0.021669113484743076f);
skate0.transform.rotation = Quaternion.Euler(0,64.48056503444798f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.024012079538965676f,0f,0.021669113484743076f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.2040048684131524f);
moveline0 = Instantiate(moveline,new Vector3(-0.024012079538965676f,0f,0.021669113484743076f),Quaternion.Euler(0,-152.18873385392467f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.1804401134433507f);
skate1.transform.position = new Vector3(2.4759879204610344f,0f,-0.021669113484743076f);
skate1.transform.rotation = Quaternion.Euler(0,115.51943496555202f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.4759879204610344f,0f,-0.021669113484743076f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.2040048684131524f);
moveline1 = Instantiate(moveline,new Vector3(2.4759879204610344f,0f,-0.021669113484743076f),Quaternion.Euler(0,-27.81126614607531f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.1804401134433507f);
}
}
public class frame17 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.02691635254061401f,0f,0.02401766707982242f);
skate0.transform.rotation = Quaternion.Euler(0,66.91563566375397f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.02691635254061401f,0f,0.02401766707982242f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.20447599767149013f);
moveline0 = Instantiate(moveline,new Vector3(-0.02691635254061401f,0f,0.02401766707982242f),Quaternion.Euler(0,-154.48056503444798f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.18452715601985692f);
skate1.transform.position = new Vector3(2.473083647459386f,0f,-0.02401766707982242f);
skate1.transform.rotation = Quaternion.Euler(0,113.08436433624603f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.473083647459386f,0f,-0.02401766707982242f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.20447599767149013f);
moveline1 = Instantiate(moveline,new Vector3(2.473083647459386f,0f,-0.02401766707982242f),Quaternion.Euler(0,-25.519434965552023f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.18452715601985692f);
}
}
public class frame18 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.029952639240873016f,0f,0.026422486714107123f);
skate0.transform.rotation = Quaternion.Euler(0,69.49394574184268f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.029952639240873016f,0f,0.026422486714107123f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.20496112903197616f);
moveline0 = Instantiate(moveline,new Vector3(-0.029952639240873016f,0f,0.026422486714107123f),Quaternion.Euler(0,-156.91563566375396f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.1885495900232002f);
skate1.transform.position = new Vector3(2.470047360759127f,0f,-0.026422486714107123f);
skate1.transform.rotation = Quaternion.Euler(0,110.50605425815732f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.470047360759127f,0f,-0.026422486714107123f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.20496112903197616f);
moveline1 = Instantiate(moveline,new Vector3(2.470047360759127f,0f,-0.026422486714107123f),Quaternion.Euler(0,-23.084364336246026f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.1885495900232002f);
}
}
public class frame19 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.03310930564489002f,0f,0.028872328974195352f);
skate0.transform.rotation = Quaternion.Euler(0,72.2154952687141f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.03310930564489002f,0f,0.028872328974195352f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.2054578866765394f);
moveline0 = Instantiate(moveline,new Vector3(-0.03310930564489002f,0f,0.028872328974195352f),Quaternion.Euler(0,-159.4939457418427f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.1924390844123566f);
skate1.transform.position = new Vector3(2.46689069435511f,0f,-0.028872328974195352f);
skate1.transform.rotation = Quaternion.Euler(0,107.7845047312859f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.46689069435511f,0f,-0.028872328974195352f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.2054578866765394f);
moveline1 = Instantiate(moveline,new Vector3(2.46689069435511f,0f,-0.028872328974195352f),Quaternion.Euler(0,-20.506054258157306f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.1924390844123566f);
}
}
public class frame20 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.03637294146497175f,0f,0.031356483448031804f);
skate0.transform.rotation = Quaternion.Euler(0,75.08028424436822f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.03637294146497175f,0f,0.031356483448031804f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.20596394869051543f);
moveline0 = Instantiate(moveline,new Vector3(-0.03637294146497175f,0f,0.031356483448031804f),Quaternion.Euler(0,-162.21549526871414f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.19612134994010016f);
skate1.transform.position = new Vector3(2.463627058535028f,0f,-0.031356483448031804f);
skate1.transform.rotation = Quaternion.Euler(0,104.91971575563178f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.463627058535028f,0f,-0.031356483448031804f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.20596394869051543f);
moveline1 = Instantiate(moveline,new Vector3(2.463627058535028f,0f,-0.031356483448031804f),Quaternion.Euler(0,-17.784504731285892f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.19612134994010016f);
}
}
public class frame21 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.03972830677489363f,0f,0.03386507905431043f);
skate0.transform.rotation = Quaternion.Euler(0,78.08831266880503f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.03972830677489363f,0f,0.03386507905431043f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.2064771032323737f);
moveline0 = Instantiate(moveline,new Vector3(-0.03972830677489363f,0f,0.03386507905431043f),Quaternion.Euler(0,-165.0802842443682f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.19951625245192348f);
skate1.transform.position = new Vector3(2.4602716932251063f,0f,-0.03386507905431043f);
skate1.transform.rotation = Quaternion.Euler(0,101.91168733119497f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.4602716932251063f,0f,-0.03386507905431043f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.2064771032323737f);
moveline1 = Instantiate(moveline,new Vector3(2.4602716932251063f,0f,-0.03386507905431043f),Quaternion.Euler(0,-14.919715755631785f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.19951625245192348f);
}
}
public class frame22 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.0431583231945576f,0f,0.03638942202124963f);
skate0.transform.rotation = Quaternion.Euler(0,81.23958054202457f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.0431583231945576f,0f,0.03638942202124963f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.20699531179978498f);
moveline0 = Instantiate(moveline,new Vector3(-0.0431583231945576f,0f,0.03638942202124963f),Quaternion.Euler(0,-168.08831266880503f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.20253806161389293f);
skate1.transform.position = new Vector3(2.456841676805442f,0f,-0.03638942202124963f);
skate1.transform.rotation = Quaternion.Euler(0,98.76041945797543f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.456841676805442f,0f,-0.03638942202124963f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.20699531179978498f);
moveline1 = Instantiate(moveline,new Vector3(2.456841676805442f,0f,-0.03638942202124963f),Quaternion.Euler(0,-11.911687331194969f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.20253806161389293f);
}
}
public class frame23 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.046644119504434194f,0f,0.03892236071881381f);
skate0.transform.rotation = Quaternion.Euler(0,84.5340878640268f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.046644119504434194f,0f,0.03892236071881381f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.20751677903894458f);
moveline0 = Instantiate(moveline,new Vector3(-0.046644119504434194f,0f,0.03892236071881381f),Quaternion.Euler(0,-171.2395805420246f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.20509585299644742f);
skate1.transform.position = new Vector3(2.4533558804955655f,0f,-0.03892236071881381f);
skate1.transform.rotation = Quaternion.Euler(0,95.4659121359732f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.4533558804955655f,0f,-0.03892236071881381f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.20751677903894458f);
moveline1 = Instantiate(moveline,new Vector3(2.4533558804955655f,0f,-0.03892236071881381f),Quaternion.Euler(0,-8.76041945797543f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.20509585299644742f);
}
}
public class frame24 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.05016514160348376f,0f,0.04145867012356674f);
skate0.transform.rotation = Quaternion.Euler(0,87.97183463481174f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.05016514160348376f,0f,0.04145867012356674f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.20804002810850863f);
moveline0 = Instantiate(moveline,new Vector3(-0.05016514160348376f,0f,0.04145867012356674f),Quaternion.Euler(0,-174.53408786402684f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.20709407950287825f);
skate1.transform.position = new Vector3(2.449834858396516f,0f,-0.04145867012356674f);
skate1.transform.rotation = Quaternion.Euler(0,92.02816536518826f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.449834858396516f,0f,-0.04145867012356674f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.20804002810850863f);
moveline1 = Instantiate(moveline,new Vector3(2.449834858396516f,0f,-0.04145867012356674f),Quaternion.Euler(0,-5.465912135973198f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.20709407950287825f);
}
}
public class frame25 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.05369933623139185f,0f,0.04399544600650189f);
skate0.transform.rotation = Quaternion.Euler(0,91.55282085437939f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.05369933623139185f,0f,0.04399544600650189f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.2085639801084321f);
moveline0 = Instantiate(moveline,new Vector3(-0.05369933623139185f,0f,0.04399544600650189f),Quaternion.Euler(0,-177.97183463481173f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.20843332529308492f);
skate1.transform.position = new Vector3(2.446300663768608f,0f,-0.04399544600650189f);
skate1.transform.rotation = Quaternion.Euler(0,88.44717914562061f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.446300663768608f,0f,-0.04399544600650189f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.2085639801084321f);
moveline1 = Instantiate(moveline,new Vector3(2.446300663768608f,0f,-0.04399544600650189f),Quaternion.Euler(0,-2.028165365188258f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.20843332529308492f);
}
}
public class frame26 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.05728192107173703f,0f,0.04583350903806823f);
skate0.transform.rotation = Quaternion.Euler(0,94.99056762516433f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.05728192107173703f,0f,0.04583350903806823f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.3909119644717118f);
moveline0 = Instantiate(moveline,new Vector3(-0.05728192107173703f,0f,0.04583350903806823f),Quaternion.Euler(0,-1.5528208543793909f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.4427180789282628f,0f,-0.04583350903806823f);
skate1.transform.rotation = Quaternion.Euler(0,85.00943237483567f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.4427180789282628f,0f,-0.04583350903806823f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.3909119644717118f);
moveline1 = Instantiate(moveline,new Vector3(2.4427180789282628f,0f,-0.04583350903806823f),Quaternion.Euler(0,-178.44717914562062f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame27 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.06101984830854975f,0f,0.046967423473061876f);
skate0.transform.rotation = Quaternion.Euler(0,98.28507494716656f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.06101984830854975f,0f,0.046967423473061876f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.3905322467741548f);
moveline0 = Instantiate(moveline,new Vector3(-0.06101984830854975f,0f,0.046967423473061876f),Quaternion.Euler(0,-4.990567625164331f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.43898015169145f,0f,-0.046967423473061876f);
skate1.transform.rotation = Quaternion.Euler(0,81.71492505283344f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.43898015169145f,0f,-0.046967423473061876f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.3905322467741548f);
moveline1 = Instantiate(moveline,new Vector3(2.43898015169145f,0f,-0.046967423473061876f),Quaternion.Euler(0,-175.00943237483568f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame28 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.06501509417613778f,0f,0.047385740345369506f);
skate0.transform.rotation = Quaternion.Euler(0,101.43634282038609f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.06501509417613778f,0f,0.047385740345369506f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.3902979941365536f);
moveline0 = Instantiate(moveline,new Vector3(-0.06501509417613778f,0f,0.047385740345369506f),Quaternion.Euler(0,-8.28507494716655f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.434984905823862f,0f,-0.047385740345369506f);
skate1.transform.rotation = Quaternion.Euler(0,78.56365717961391f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.434984905823862f,0f,-0.047385740345369506f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.3902979941365536f);
moveline1 = Instantiate(moveline,new Vector3(2.434984905823862f,0f,-0.047385740345369506f),Quaternion.Euler(0,-171.71492505283345f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame29 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.06936440984447417f,0f,0.04707179655400273f);
skate0.transform.rotation = Quaternion.Euler(0,104.44437124482292f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.06936440984447417f,0f,0.04707179655400273f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.390211574665555f);
moveline0 = Instantiate(moveline,new Vector3(-0.06936440984447417f,0f,0.04707179655400273f),Quaternion.Euler(0,-11.436342820386088f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.430635590155526f,0f,-0.04707179655400273f);
skate1.transform.rotation = Quaternion.Euler(0,75.55562875517708f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.430635590155526f,0f,-0.04707179655400273f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.390211574665555f);
moveline1 = Instantiate(moveline,new Vector3(2.430635590155526f,0f,-0.04707179655400273f),Quaternion.Euler(0,-168.56365717961387f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame30 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.07415915391793118f,0f,0.04600448463287138f);
skate0.transform.rotation = Quaternion.Euler(0,107.30916022047703f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.07415915391793118f,0f,0.04600448463287138f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.390276431874799f);
moveline0 = Instantiate(moveline,new Vector3(-0.07415915391793118f,0f,0.04600448463287138f),Quaternion.Euler(0,-14.444371244822918f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.425840846082069f,0f,-0.04600448463287138f);
skate1.transform.rotation = Quaternion.Euler(0,72.69083977952297f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.425840846082069f,0f,-0.04600448463287138f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.390276431874799f);
moveline1 = Instantiate(moveline,new Vector3(2.425840846082069f,0f,-0.04600448463287138f),Quaternion.Euler(0,-165.55562875517705f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame31 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.07948519712285498f,0f,0.04415898756665549f);
skate0.transform.rotation = Quaternion.Euler(0,110.03070974734844f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.07948519712285498f,0f,0.04415898756665549f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.3904969254407302f);
moveline0 = Instantiate(moveline,new Vector3(-0.07948519712285498f,0f,0.04415898756665549f),Quaternion.Euler(0,-17.30916022047704f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.420514802877145f,0f,-0.04415898756665549f);
skate1.transform.rotation = Quaternion.Euler(0,69.96929025265156f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.420514802877145f,0f,-0.04415898756665549f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.3904969254407302f);
moveline1 = Instantiate(moveline,new Vector3(2.420514802877145f,0f,-0.04415898756665549f),Quaternion.Euler(0,-162.69083977952295f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame32 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.08419959076268232f,0f,0.04150747440841622f);
skate0.transform.rotation = Quaternion.Euler(0,112.60901982543714f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.08419959076268232f,0f,0.04150747440841622f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.3908781792715597f);
moveline0 = Instantiate(moveline,new Vector3(-0.08419959076268232f,0f,0.04150747440841622f),Quaternion.Euler(0,20.030709747348453f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.4158004092373178f,0f,-0.04150747440841622f);
skate1.transform.rotation = Quaternion.Euler(0,67.39098017456286f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.4158004092373178f,0f,-0.04150747440841622f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.3908781792715597f);
moveline1 = Instantiate(moveline,new Vector3(2.4158004092373178f,0f,-0.04150747440841622f),Quaternion.Euler(0,159.96929025265155f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame33 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.08822748323310352f,0f,0.03801975369646303f);
skate0.transform.rotation = Quaternion.Euler(0,115.04409045474316f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.08822748323310352f,0f,0.03801975369646303f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.3914259378114768f);
moveline0 = Instantiate(moveline,new Vector3(-0.08822748323310352f,0f,0.03801975369646303f),Quaternion.Euler(0,22.609019825437144f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.4117725167668964f,0f,-0.03801975369646303f);
skate1.transform.rotation = Quaternion.Euler(0,64.95590954525684f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.4117725167668964f,0f,-0.03801975369646303f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.3914259378114768f);
moveline1 = Instantiate(moveline,new Vector3(2.4117725167668964f,0f,-0.03801975369646303f),Quaternion.Euler(0,157.39098017456286f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame34 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.09149945505749568f,0f,0.03366388275725936f);
skate0.transform.rotation = Quaternion.Euler(0,117.33592163526644f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.09149945505749568f,0f,0.03366388275725936f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.3921464312585587f);
moveline0 = Instantiate(moveline,new Vector3(-0.09149945505749568f,0f,0.03366388275725936f),Quaternion.Euler(0,25.04409045474314f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.408500544942504f,0f,-0.03366388275725936f);
skate1.transform.rotation = Quaternion.Euler(0,62.664078364733555f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.408500544942504f,0f,-0.03366388275725936f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.3921464312585587f);
moveline1 = Instantiate(moveline,new Vector3(2.408500544942504f,0f,-0.03366388275725936f),Quaternion.Euler(0,154.95590954525687f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame35 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.09395141512545954f,0f,0.028406731920128384f);
skate0.transform.rotation = Quaternion.Euler(0,119.48451336700703f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.09395141512545954f,0f,0.028406731920128384f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.3930462501610705f);
moveline0 = Instantiate(moveline,new Vector3(-0.09395141512545954f,0f,0.028406731920128384f),Quaternion.Euler(0,27.335921635266445f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.40604858487454f,0f,-0.028406731920128384f);
skate1.transform.rotation = Quaternion.Euler(0,60.515486632992975f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.40604858487454f,0f,-0.028406731920128384f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.3930462501610705f);
moveline1 = Instantiate(moveline,new Vector3(2.40604858487454f,0f,-0.028406731920128384f),Quaternion.Euler(0,152.66407836473354f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame36 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.09552446753039412f,0f,0.022214503463325798f);
skate0.transform.rotation = Quaternion.Euler(0,121.48986564996491f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.09552446753039412f,0f,0.022214503463325798f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.3941322296723067f);
moveline0 = Instantiate(moveline,new Vector3(-0.09552446753039412f,0f,0.022214503463325798f),Quaternion.Euler(0,29.484513367007033f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.4044755324696054f,0f,-0.022214503463325798f);
skate1.transform.rotation = Quaternion.Euler(0,58.51013435003509f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.4044755324696054f,0f,-0.022214503463325798f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.3941322296723067f);
moveline1 = Instantiate(moveline,new Vector3(2.4044755324696054f,0f,-0.022214503463325798f),Quaternion.Euler(0,150.51548663299297f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame37 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.09616475610774361f,0f,0.015053205766902271f);
skate0.transform.rotation = Quaternion.Euler(0,123.35197848414009f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.09616475610774361f,0f,0.015053205766902271f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.395411343587509f);
moveline0 = Instantiate(moveline,new Vector3(-0.09616475610774361f,0f,0.015053205766902271f),Quaternion.Euler(0,31.489865649964912f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.403835243892256f,0f,-0.015053205766902271f);
skate1.transform.rotation = Quaternion.Euler(0,56.64802151585992f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.403835243892256f,0f,-0.015053205766902271f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.395411343587509f);
moveline1 = Instantiate(moveline,new Vector3(2.403835243892256f,0f,-0.015053205766902271f),Quaternion.Euler(0,148.5101343500351f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame38 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.09582329319794176f,0f,0.006889083674426897f);
skate0.transform.rotation = Quaternion.Euler(0,125.07085186953256f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.09582329319794176f,0f,0.006889083674426897f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.3968906081558952f);
moveline0 = Instantiate(moveline,new Vector3(-0.09582329319794176f,0f,0.006889083674426897f),Quaternion.Euler(0,33.35197848414008f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.404176706802058f,0f,-0.006889083674426897f);
skate1.transform.rotation = Quaternion.Euler(0,54.929148130467446f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.404176706802058f,0f,-0.006889083674426897f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.3968906081558952f);
moveline1 = Instantiate(moveline,new Vector3(2.404176706802058f,0f,-0.006889083674426897f),Quaternion.Euler(0,146.6480215158599f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame39 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.0944557785744713f,0f,-0.002310993527163222f);
skate0.transform.rotation = Quaternion.Euler(0,126.64648580614232f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.0944557785744713f,0f,-0.002310993527163222f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.3985769955543619f);
moveline0 = Instantiate(moveline,new Vector3(-0.0944557785744713f,0f,-0.002310993527163222f),Quaternion.Euler(0,35.07085186953256f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.4055442214255285f,0f,0.002310993527163222f);
skate1.transform.rotation = Quaternion.Euler(0,53.353514193857684f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.4055442214255285f,0f,0.002310993527163222f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.3985769955543619f);
moveline1 = Instantiate(moveline,new Vector3(2.4055442214255285f,0f,0.002310993527163222f),Quaternion.Euler(0,144.92914813046744f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame40 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.09202241389946356f,0f,-0.012579184802254421f);
skate0.transform.rotation = Quaternion.Euler(0,128.07888029396938f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.09202241389946356f,0f,-0.012579184802254421f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.4004773568247286f);
moveline0 = Instantiate(moveline,new Vector3(-0.09202241389946356f,0f,-0.012579184802254421f),Quaternion.Euler(0,36.64648580614232f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.4079775861005364f,0f,0.012579184802254421f);
skate1.transform.rotation = Quaternion.Euler(0,51.92111970603062f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.4079775861005364f,0f,0.012579184802254421f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.4004773568247286f);
moveline1 = Instantiate(moveline,new Vector3(2.4079775861005364f,0f,0.012579184802254421f),Quaternion.Euler(0,143.35351419385768f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame41 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.08848771750595004f,0f,-0.023946368828961846f);
skate0.transform.rotation = Quaternion.Euler(0,129.36803533301372f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.08848771750595004f,0f,-0.023946368828961846f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.402598354011169f);
moveline0 = Instantiate(moveline,new Vector3(-0.08848771750595004f,0f,-0.023946368828961846f),Quaternion.Euler(0,38.078880293969384f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.41151228249405f,0f,0.023946368828961846f);
skate1.transform.rotation = Quaternion.Euler(0,50.63196466698627f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.41151228249405f,0f,0.023946368828961846f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.402598354011169f);
moveline1 = Instantiate(moveline,new Vector3(2.41151228249405f,0f,0.023946368828961846f),Quaternion.Euler(0,141.92111970603062f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame42 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.08382034376398625f,0f,-0.036441872211008586f);
skate0.transform.rotation = Quaternion.Euler(0,130.5139509232754f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.08382034376398625f,0f,-0.036441872211008586f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.4049464011864945f);
moveline0 = Instantiate(moveline,new Vector3(-0.08382034376398625f,0f,-0.036441872211008586f),Quaternion.Euler(0,39.36803533301374f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.4161796562360136f,0f,0.036441872211008586f);
skate1.transform.rotation = Quaternion.Euler(0,49.486049076724626f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.4161796562360136f,0f,0.036441872211008586f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.4049464011864945f);
moveline1 = Instantiate(moveline,new Vector3(2.4161796562360136f,0f,0.036441872211008586f),Quaternion.Euler(0,140.63196466698628f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame43 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.07799291077206023f,0f,-0.050093232387291686f);
skate0.transform.rotation = Quaternion.Euler(0,131.51662706475432f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.07799291077206023f,0f,-0.050093232387291686f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.407527614023111f);
moveline0 = Instantiate(moveline,new Vector3(-0.07799291077206023f,0f,-0.050093232387291686f),Quaternion.Euler(0,40.51395092327538f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.4220070892279395f,0f,0.050093232387291686f);
skate1.transform.rotation = Quaternion.Euler(0,48.48337293524568f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.4220070892279395f,0f,0.050093232387291686f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.407527614023111f);
moveline1 = Instantiate(moveline,new Vector3(2.4220070892279395f,0f,0.050093232387291686f),Quaternion.Euler(0,139.4860490767246f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame44 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.0709818396282885f,0f,-0.06492599322188931f);
skate0.transform.rotation = Quaternion.Euler(0,132.37606375745054f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.0709818396282885f,0f,-0.06492599322188931f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.4103477675448055f);
moveline0 = Instantiate(moveline,new Vector3(-0.0709818396282885f,0f,-0.06492599322188931f),Quaternion.Euler(0,41.51662706475432f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.429018160371711f,0f,0.06492599322188931f);
skate1.transform.rotation = Quaternion.Euler(0,47.62393624254945f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.429018160371711f,0f,0.06492599322188931f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.4103477675448055f);
moveline1 = Instantiate(moveline,new Vector3(2.429018160371711f,0f,0.06492599322188931f),Quaternion.Euler(0,138.48337293524568f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame45 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.0627672080790938f,0f,-0.08096353135065718f);
skate0.transform.rotation = Quaternion.Euler(0,133.09226100136408f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.0627672080790938f,0f,-0.08096353135065718f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.4134122616873515f);
moveline0 = Instantiate(moveline,new Vector3(-0.0627672080790938f,0f,-0.08096353135065718f),Quaternion.Euler(0,42.37606375745055f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.437232791920906f,0f,0.08096353135065718f);
skate1.transform.rotation = Quaternion.Euler(0,46.90773899863592f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.437232791920906f,0f,0.08096353135065718f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.4134122616873515f);
moveline1 = Instantiate(moveline,new Vector3(2.437232791920906f,0f,0.08096353135065718f),Quaternion.Euler(0,137.62393624254946f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame46 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.053332620916159416f,0f,-0.09822691150417714f);
skate0.transform.rotation = Quaternion.Euler(0,133.6652187964949f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.053332620916159416f,0f,-0.09822691150417714f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.4167260942977251f);
moveline0 = Instantiate(moveline,new Vector3(-0.053332620916159416f,0f,-0.09822691150417714f),Quaternion.Euler(0,43.09226100136408f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.4466673790838405f,0f,0.09822691150417714f);
skate1.transform.rotation = Quaternion.Euler(0,46.3347812035051f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.4466673790838405f,0f,0.09822691150417714f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.4167260942977251f);
moveline1 = Instantiate(moveline,new Vector3(2.4466673790838405f,0f,0.09822691150417714f),Quaternion.Euler(0,136.90773899863592f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame47 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.04266509909408648f,0f,-0.11673476921265157f);
skate0.transform.rotation = Quaternion.Euler(0,134.094937142843f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.04266509909408648f,0f,-0.11673476921265157f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.4202938412122914f);
moveline0 = Instantiate(moveline,new Vector3(-0.04266509909408648f,0f,-0.11673476921265157f),Quaternion.Euler(0,43.665218796494905f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
skate1.transform.position = new Vector3(2.4573349009059133f,0f,0.11673476921265157f);
skate1.transform.rotation = Quaternion.Euler(0,45.905062857156985f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.4573349009059133f,0f,0.11673476921265157f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.4202938412122914f);
moveline1 = Instantiate(moveline,new Vector3(2.4573349009059133f,0f,0.11673476921265157f),Quaternion.Euler(0,136.3347812035051f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
}
}
public class frame48 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.03075498916897238f,0f,-0.13650321951899017f);
skate0.transform.rotation = Quaternion.Euler(0,134.38141604040842f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.03075498916897238f,0f,-0.13650321951899017f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.4241196430725958f);
moveline0 = Instantiate(moveline,new Vector3(-0.03075498916897238f,0f,-0.13650321951899017f),Quaternion.Euler(0,44.094937142843015f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.4692450108310275f,0f,0.13650321951899017f);
skate1.transform.rotation = Quaternion.Euler(0,45.618583959591575f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.4692450108310275f,0f,0.13650321951899017f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.4241196430725958f);
moveline1 = Instantiate(moveline,new Vector3(2.4692450108310275f,0f,0.13650321951899017f),Quaternion.Euler(0,135.905062857157f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame49 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.017595894308887628f,0f,-0.15754579057499718f);
skate0.transform.rotation = Quaternion.Euler(0,134.52465548919113f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.017595894308887628f,0f,-0.15754579057499718f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.4282071985626388f);
moveline0 = Instantiate(moveline,new Vector3(-0.017595894308887628f,0f,-0.15754579057499718f),Quaternion.Euler(0,44.38141604040843f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.482404105691112f,0f,0.15754579057499718f);
skate1.transform.rotation = Quaternion.Euler(0,45.47534451080887f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.482404105691112f,0f,0.15754579057499718f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.4282071985626388f);
moveline1 = Instantiate(moveline,new Vector3(2.482404105691112f,0f,0.15754579057499718f),Quaternion.Euler(0,135.61858395959158f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame50 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(-0.003184627797112264f,0f,-0.17987338126592792f);
skate0.transform.rotation = Quaternion.Euler(0,134.52465548919113f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(-0.003184627797112264f,0f,-0.17987338126592792f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.4325597637830914f);
moveline0 = Instantiate(moveline,new Vector3(-0.003184627797112264f,0f,-0.17987338126592792f),Quaternion.Euler(0,44.52465548919113f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.4968153722028874f,0f,0.17987338126592792f);
skate1.transform.rotation = Quaternion.Euler(0,45.47534451080887f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.4968153722028874f,0f,0.17987338126592792f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.4325597637830914f);
moveline1 = Instantiate(moveline,new Vector3(2.4968153722028874f,0f,0.17987338126592792f),Quaternion.Euler(0,135.47534451080887f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame51 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.012478810366353711f,0f,-0.2013513851520188f);
skate0.transform.rotation = Quaternion.Euler(0,134.38141604040842f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.012478810366353711f,0f,-0.2013513851520188f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.23718015751546778f);
moveline0 = Instantiate(moveline,new Vector3(0.012478810366353711f,0f,-0.2013513851520188f),Quaternion.Euler(0,44.52465548919113f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.5124788103663533f,0f,0.2013513851520188f);
skate1.transform.rotation = Quaternion.Euler(0,45.61858395959158f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.5124788103663533f,0f,0.2013513851520188f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.23718015751546778f);
moveline1 = Instantiate(moveline,new Vector3(2.5124788103663533f,0f,0.2013513851520188f),Quaternion.Euler(0,135.47534451080887f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame52 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.02939123346479034f,0f,-0.22198461654428692f);
skate0.transform.rotation = Quaternion.Euler(0,134.094937142843f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.02939123346479034f,0f,-0.22198461654428692f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.2416269822075745f);
moveline0 = Instantiate(moveline,new Vector3(0.02939123346479034f,0f,-0.22198461654428692f),Quaternion.Euler(0,44.381416040408425f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
skate1.transform.position = new Vector3(2.52939123346479f,0f,0.22198461654428692f);
skate1.transform.rotation = Quaternion.Euler(0,45.90506285715699f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.52939123346479f,0f,0.22198461654428692f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.2416269822075745f);
moveline1 = Instantiate(moveline,new Vector3(2.52939123346479f,0f,0.22198461654428692f),Quaternion.Euler(0,135.61858395959158f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
}
}
public class frame53 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.04754624466626813f,0f,-0.24177447907198185f);
skate0.transform.rotation = Quaternion.Euler(0,133.66521879649488f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.04754624466626813f,0f,-0.24177447907198185f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.24590122410768284f);
moveline0 = Instantiate(moveline,new Vector3(0.04754624466626813f,0f,-0.24177447907198185f),Quaternion.Euler(0,44.09493714284301f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.547546244666268f,0f,0.24177447907198185f);
skate1.transform.rotation = Quaternion.Euler(0,46.33478120350511f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.547546244666268f,0f,0.24177447907198185f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.24590122410768284f);
moveline1 = Instantiate(moveline,new Vector3(2.547546244666268f,0f,0.24177447907198185f),Quaternion.Euler(0,135.905062857157f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame54 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.06693419052688447f,0f,-0.2607190142888222f);
skate0.transform.rotation = Quaternion.Euler(0,133.09226100136408f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.06693419052688447f,0f,-0.2607190142888222f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.25000311635923234f);
moveline0 = Instantiate(moveline,new Vector3(0.06693419052688447f,0f,-0.2607190142888222f),Quaternion.Euler(0,43.6652187964949f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.5669341905268843f,0f,0.2607190142888222f);
skate1.transform.rotation = Quaternion.Euler(0,46.90773899863593f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.5669341905268843f,0f,0.2607190142888222f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.25000311635923234f);
moveline1 = Instantiate(moveline,new Vector3(2.5669341905268843f,0f,0.2607190142888222f),Quaternion.Euler(0,136.3347812035051f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame55 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.08754209200124052f,0f,-0.27881297377798253f);
skate0.transform.rotation = Quaternion.Euler(0,132.37606375745054f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.08754209200124052f,0f,-0.27881297377798253f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.2539321529357222f);
moveline0 = Instantiate(moveline,new Vector3(0.08754209200124052f,0f,-0.27881297377798253f),Quaternion.Euler(0,43.09226100136407f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.5875420920012404f,0f,0.27881297377798253f);
skate1.transform.rotation = Quaternion.Euler(0,47.623936242549455f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.5875420920012404f,0f,0.27881297377798253f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.2539321529357222f);
moveline1 = Instantiate(moveline,new Vector3(2.5875420920012404f,0f,0.27881297377798253f),Quaternion.Euler(0,136.90773899863592f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame56 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.10694643307017362f,0f,-0.29868626198841725f);
skate0.transform.rotation = Quaternion.Euler(0,131.51662706475432f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.10694643307017362f,0f,-0.29868626198841725f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.2576871069616467f);
moveline0 = Instantiate(moveline,new Vector3(0.10694643307017362f,0f,-0.29868626198841725f),Quaternion.Euler(0,-137.62393624254946f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.6069464330701737f,0f,0.29868626198841725f);
skate1.transform.rotation = Quaternion.Euler(0,48.48337293524569f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.6069464330701737f,0f,0.29868626198841725f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.2576871069616467f);
moveline1 = Instantiate(moveline,new Vector3(2.6069464330701737f,0f,0.29868626198841725f),Quaternion.Euler(0,-42.37606375745054f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame57 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.12753441229095244f,0f,-0.317689997927787f);
skate0.transform.rotation = Quaternion.Euler(0,130.51395092327536f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.12753441229095244f,0f,-0.317689997927787f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.26181412709230234f);
moveline0 = Instantiate(moveline,new Vector3(0.12753441229095244f,0f,-0.317689997927787f),Quaternion.Euler(0,41.51662706475431f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.6275344122909523f,0f,0.317689997927787f);
skate1.transform.rotation = Quaternion.Euler(0,49.48604907672463f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.6275344122909523f,0f,0.317689997927787f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.26181412709230234f);
moveline1 = Instantiate(moveline,new Vector3(2.6275344122909523f,0f,0.317689997927787f),Quaternion.Euler(0,138.48337293524568f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame58 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.1492824507616935f,0f,-0.3358107261943962f);
skate0.transform.rotation = Quaternion.Euler(0,129.36803533301372f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.1492824507616935f,0f,-0.3358107261943962f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.26576351250482605f);
moveline0 = Instantiate(moveline,new Vector3(0.1492824507616935f,0f,-0.3358107261943962f),Quaternion.Euler(0,40.51395092327537f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.649282450761693f,0f,0.3358107261943962f);
skate1.transform.rotation = Quaternion.Euler(0,50.63196466698628f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.649282450761693f,0f,0.3358107261943962f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.26576351250482605f);
moveline1 = Instantiate(moveline,new Vector3(2.649282450761693f,0f,0.3358107261943962f),Quaternion.Euler(0,139.48604907672464f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame59 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.17079447095985506f,0f,-0.35412510164403666f);
skate0.transform.rotation = Quaternion.Euler(0,128.07888029396938f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.17079447095985506f,0f,-0.35412510164403666f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.26953224320588864f);
moveline0 = Instantiate(moveline,new Vector3(0.17079447095985506f,0f,-0.35412510164403666f),Quaternion.Euler(0,-39.36803533301372f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.20837202483338832f);
skate1.transform.position = new Vector3(2.6707944709598546f,0f,0.35412510164403666f);
skate1.transform.rotation = Quaternion.Euler(0,51.92111970603063f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.6707944709598546f,0f,0.35412510164403666f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.26953224320588864f);
moveline1 = Instantiate(moveline,new Vector3(2.6707944709598546f,0f,0.35412510164403666f),Quaternion.Euler(0,-140.63196466698628f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.20837202483338832f);
}
}
public class frame60 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.1934078228765224f,0f,-0.3715219446548171f);
skate0.transform.rotation = Quaternion.Euler(0,126.64648580614232f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.1934078228765224f,0f,-0.3715219446548171f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.273344247344457f);
moveline0 = Instantiate(moveline,new Vector3(0.1934078228765224f,0f,-0.3715219446548171f),Quaternion.Euler(0,38.07888029396937f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.6934078228765217f,0f,0.3715219446548171f);
skate1.transform.rotation = Quaternion.Euler(0,53.353514193857684f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.6934078228765217f,0f,0.3715219446548171f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.273344247344457f);
moveline1 = Instantiate(moveline,new Vector3(2.6934078228765217f,0f,0.3715219446548171f),Quaternion.Euler(0,141.92111970603062f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame61 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.217087024844727f,0f,-0.3879806354213697f);
skate0.transform.rotation = Quaternion.Euler(0,125.07085186953256f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.217087024844727f,0f,-0.3879806354213697f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.2769682188965386f);
moveline0 = Instantiate(moveline,new Vector3(0.217087024844727f,0f,-0.3879806354213697f),Quaternion.Euler(0,36.646485806142316f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.7170870248447265f,0f,0.3879806354213697f);
skate1.transform.rotation = Quaternion.Euler(0,54.929148130467446f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.7170870248447265f,0f,0.3879806354213697f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.2769682188965386f);
moveline1 = Instantiate(moveline,new Vector3(2.7170870248447265f,0f,0.3879806354213697f),Quaternion.Euler(0,143.35351419385768f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame62 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.24053075738875154f,0f,-0.4046046379745166f);
skate0.transform.rotation = Quaternion.Euler(0,123.35197848414008f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.24053075738875154f,0f,-0.4046046379745166f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.2803995371469825f);
moveline0 = Instantiate(moveline,new Vector3(0.24053075738875154f,0f,-0.4046046379745166f),Quaternion.Euler(0,-35.07085186953255f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.22949079568139785f);
skate1.transform.position = new Vector3(2.740530757388751f,0f,0.4046046379745166f);
skate1.transform.rotation = Quaternion.Euler(0,56.648021515859924f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.740530757388751f,0f,0.4046046379745166f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.2803995371469825f);
moveline1 = Instantiate(moveline,new Vector3(2.740530757388751f,0f,0.4046046379745166f),Quaternion.Euler(0,-144.92914813046747f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.22949079568139785f);
}
}
public class frame63 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.2649562414199274f,0f,-0.420243924885513f);
skate0.transform.rotation = Quaternion.Euler(0,121.48986564996491f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.2649562414199274f,0f,-0.420243924885513f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.2838681867625371f);
moveline0 = Instantiate(moveline,new Vector3(0.2649562414199274f,0f,-0.420243924885513f),Quaternion.Euler(0,33.351978484140076f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.764956241419927f,0f,0.420243924885513f);
skate1.transform.rotation = Quaternion.Euler(0,58.510134350035095f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.764956241419927f,0f,0.420243924885513f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.2838681867625371f);
moveline1 = Instantiate(moveline,new Vector3(2.764956241419927f,0f,0.420243924885513f),Quaternion.Euler(0,146.6480215158599f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame64 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.29031448927868836f,0f,-0.43487321455957095f);
skate0.transform.rotation = Quaternion.Euler(0,119.48451336700703f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.29031448927868836f,0f,-0.43487321455957095f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.28713411671426636f);
moveline0 = Instantiate(moveline,new Vector3(0.29031448927868836f,0f,-0.43487321455957095f),Quaternion.Euler(0,31.489865649964898f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.7903144892786877f,0f,0.43487321455957095f);
skate1.transform.rotation = Quaternion.Euler(0,60.515486632992975f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.7903144892786877f,0f,0.43487321455957095f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.28713411671426636f);
moveline1 = Instantiate(moveline,new Vector3(2.7903144892786877f,0f,0.43487321455957095f),Quaternion.Euler(0,148.51013435003512f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame65 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.31545071754045634f,0f,-0.44962803767043613f);
skate0.transform.rotation = Quaternion.Euler(0,117.33592163526643f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.31545071754045634f,0f,-0.44962803767043613f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.29019163532546743f);
moveline0 = Instantiate(moveline,new Vector3(0.31545071754045634f,0f,-0.44962803767043613f),Quaternion.Euler(0,-29.48451336700701f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.252608557567647f);
skate1.transform.position = new Vector3(2.8154507175404557f,0f,0.44962803767043613f);
skate1.transform.rotation = Quaternion.Euler(0,62.66407836473357f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.8154507175404557f,0f,0.44962803767043613f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.29019163532546743f);
moveline1 = Instantiate(moveline,new Vector3(2.8154507175404557f,0f,0.44962803767043613f),Quaternion.Euler(0,-150.515486632993f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.252608557567647f);
}
}
public class frame66 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.34140695755865264f,0f,-0.4633202686863932f);
skate0.transform.rotation = Quaternion.Euler(0,115.04409045474314f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.34140695755865264f,0f,-0.4633202686863932f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.2932779341732573f);
moveline0 = Instantiate(moveline,new Vector3(0.34140695755865264f,0f,-0.4633202686863932f),Quaternion.Euler(0,27.33592163526643f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.841406957558652f,0f,0.4633202686863932f);
skate1.transform.rotation = Quaternion.Euler(0,64.95590954525686f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.841406957558652f,0f,0.4633202686863932f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.2932779341732573f);
moveline1 = Instantiate(moveline,new Vector3(2.841406957558652f,0f,0.4633202686863932f),Quaternion.Euler(0,152.66407836473357f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame67 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.36811911822287796f,0f,-0.47592350332425837f);
skate0.transform.rotation = Quaternion.Euler(0,112.60901982543714f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.36811911822287796f,0f,-0.47592350332425837f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.2961443322668092f);
moveline0 = Instantiate(moveline,new Vector3(0.36811911822287796f,0f,-0.47592350332425837f),Quaternion.Euler(0,25.04409045474314f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.8681191182228774f,0f,0.47592350332425837f);
skate1.transform.rotation = Quaternion.Euler(0,67.39098017456286f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.8681191182228774f,0f,0.47592350332425837f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.2961443322668092f);
moveline1 = Instantiate(moveline,new Vector3(2.8681191182228774f,0f,0.47592350332425837f),Quaternion.Euler(0,154.95590954525687f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame68 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.39551778005650945f,0f,-0.4874118006804538f);
skate0.transform.rotation = Quaternion.Euler(0,110.03070974734842f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.39551778005650945f,0f,-0.4874118006804538f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.2987848299966401f);
moveline0 = Instantiate(moveline,new Vector3(0.39551778005650945f,0f,-0.4874118006804538f),Quaternion.Euler(0,22.609019825437144f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.8955177800565086f,0f,0.4874118006804538f);
skate1.transform.rotation = Quaternion.Euler(0,69.96929025265158f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.8955177800565086f,0f,0.4874118006804538f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.2987848299966401f);
moveline1 = Instantiate(moveline,new Vector3(2.8955177800565086f,0f,0.4874118006804538f),Quaternion.Euler(0,157.39098017456286f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame69 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.4235280914552374f,0f,-0.49776024866644125f);
skate0.transform.rotation = Quaternion.Euler(0,107.30916022047703f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.4235280914552374f,0f,-0.49776024866644125f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.3011935204220045f);
moveline0 = Instantiate(moveline,new Vector3(0.4235280914552374f,0f,-0.49776024866644125f),Quaternion.Euler(0,20.030709747348425f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.9235280914552364f,0f,0.49776024866644125f);
skate1.transform.rotation = Quaternion.Euler(0,72.69083977952297f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.9235280914552364f,0f,0.49776024866644125f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.3011935204220045f);
moveline1 = Instantiate(moveline,new Vector3(2.9235280914552364f,0f,0.49776024866644125f),Quaternion.Euler(0,159.96929025265158f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame70 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.4520697019854321f,0f,-0.5069455742826072f);
skate0.transform.rotation = Quaternion.Euler(0,104.4443712448229f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.4520697019854321f,0f,-0.5069455742826072f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.30336471709332963f);
moveline0 = Instantiate(moveline,new Vector3(0.4520697019854321f,0f,-0.5069455742826072f),Quaternion.Euler(0,17.309160220477025f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.952069701985431f,0f,0.5069455742826072f);
skate1.transform.rotation = Quaternion.Euler(0,75.5556287551771f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.952069701985431f,0f,0.5069455742826072f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.30336471709332963f);
moveline1 = Instantiate(moveline,new Vector3(2.952069701985431f,0f,0.5069455742826072f),Quaternion.Euler(0,162.69083977952297f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame71 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.48105674092074746f,0f,-0.5149467977783707f);
skate0.transform.rotation = Quaternion.Euler(0,101.43634282038607f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.48105674092074746f,0f,-0.5149467977783707f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.30529309178124164f);
moveline0 = Instantiate(moveline,new Vector3(0.48105674092074746f,0f,-0.5149467977783707f),Quaternion.Euler(0,14.444371244822904f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(2.9810567409207462f,0f,0.5149467977783707f);
skate1.transform.rotation = Quaternion.Euler(0,78.56365717961393f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(2.9810567409207462f,0f,0.5149467977783707f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.30529309178124164f);
moveline1 = Instantiate(moveline,new Vector3(2.9810567409207462f,0f,0.5149467977783707f),Quaternion.Euler(0,165.5556287551771f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame72 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.5103978496568112f,0f,-0.5217459288074571f);
skate0.transform.rotation = Quaternion.Euler(0,98.28507494716655f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.5103978496568112f,0f,-0.5217459288074571f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.3069738216687268f);
moveline0 = Instantiate(moveline,new Vector3(0.5103978496568112f,0f,-0.5217459288074571f),Quaternion.Euler(0,11.436342820386088f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(3.01039784965681f,0f,0.5217459288074571f);
skate1.transform.rotation = Quaternion.Euler(0,81.71492505283345f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.01039784965681f,0f,0.5217459288074571f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.3069738216687268f);
moveline1 = Instantiate(moveline,new Vector3(3.01039784965681f,0f,0.5217459288074571f),Quaternion.Euler(0,168.56365717961393f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame73 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.5399962770236503f,0f,-0.5273287015977449f);
skate0.transform.rotation = Quaternion.Euler(0,94.99056762516432f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.5399962770236503f,0f,-0.5273287015977449f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.3084027453052015f);
moveline0 = Instantiate(moveline,new Vector3(0.5399962770236503f,0f,-0.5273287015977449f),Quaternion.Euler(0,8.28507494716655f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
skate1.transform.position = new Vector3(3.039996277023649f,0f,0.5273287015977449f);
skate1.transform.rotation = Quaternion.Euler(0,85.00943237483568f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.039996277023649f,0f,0.5273287015977449f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.3084027453052015f);
moveline1 = Instantiate(moveline,new Vector3(3.039996277023649f,0f,0.5273287015977449f),Quaternion.Euler(0,171.71492505283345f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
}
}
public class frame74 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.5697500467869568f,0f,-0.5316853449123987f);
skate0.transform.rotation = Quaternion.Euler(0,91.55282085437938f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.5697500467869568f,0f,-0.5316853449123987f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.3095765263383717f);
moveline0 = Instantiate(moveline,new Vector3(0.5697500467869568f,0f,-0.5316853449123987f),Quaternion.Euler(0,4.990567625164317f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(3.069750046786955f,0f,0.5316853449123987f);
skate1.transform.rotation = Quaternion.Euler(0,88.44717914562062f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.069750046786955f,0f,0.5316853449123987f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.3095765263383717f);
moveline1 = Instantiate(moveline,new Vector3(3.069750046786955f,0f,0.5316853449123987f),Quaternion.Euler(0,175.00943237483568f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame75 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.5995522067627005f,0f,-0.5348113811842498f);
skate0.transform.rotation = Quaternion.Euler(0,87.97183463481173f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.5995522067627005f,0f,-0.5348113811842498f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.31049282373566733f);
moveline0 = Instantiate(moveline,new Vector3(0.5995522067627005f,0f,-0.5348113811842498f),Quaternion.Euler(0,1.5528208543793767f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(3.099552206762699f,0f,0.5348113811842498f);
skate1.transform.rotation = Quaternion.Euler(0,92.02816536518827f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.099552206762699f,0f,0.5348113811842498f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.31049282373566733f);
moveline1 = Instantiate(moveline,new Vector3(3.099552206762699f,0f,0.5348113811842498f),Quaternion.Euler(0,178.44717914562062f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame76 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.6292911689324311f,0f,-0.5338513048069138f);
skate0.transform.rotation = Quaternion.Euler(0,84.53408786402679f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.6292911689324311f,0f,-0.5338513048069138f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2888495331132679f);
moveline0 = Instantiate(moveline,new Vector3(0.6292911689324311f,0f,-0.5338513048069138f),Quaternion.Euler(0,-2.028165365188258f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(3.1292911689324296f,0f,0.5338513048069138f);
skate1.transform.rotation = Quaternion.Euler(0,95.46591213597321f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.1292911689324296f,0f,0.5338513048069138f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2888495331132679f);
moveline1 = Instantiate(moveline,new Vector3(3.1292911689324296f,0f,0.5338513048069138f),Quaternion.Euler(0,-177.97183463481173f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame77 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.6588600355144099f,0f,-0.5288117559822579f);
skate0.transform.rotation = Quaternion.Euler(0,81.23958054202456f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.6588600355144099f,0f,-0.5288117559822579f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.289051525305041f);
moveline0 = Instantiate(moveline,new Vector3(0.6588600355144099f,0f,-0.5288117559822579f),Quaternion.Euler(0,-5.465912135973213f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(3.1588600355144085f,0f,0.5288117559822579f);
skate1.transform.rotation = Quaternion.Euler(0,98.76041945797544f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.1588600355144085f,0f,0.5288117559822579f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.289051525305041f);
moveline1 = Instantiate(moveline,new Vector3(3.1588600355144085f,0f,0.5288117559822579f),Quaternion.Euler(0,-174.5340878640268f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame78 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.6887008719553482f,0f,-0.5232333183081248f);
skate0.transform.rotation = Quaternion.Euler(0,78.08831266880502f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.6887008719553482f,0f,-0.5232333183081248f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2901115856091026f);
moveline0 = Instantiate(moveline,new Vector3(0.6887008719553482f,0f,-0.5232333183081248f),Quaternion.Euler(0,171.23958054202456f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(3.188700871955347f,0f,0.5232333183081248f);
skate1.transform.rotation = Quaternion.Euler(0,101.91168733119498f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.188700871955347f,0f,0.5232333183081248f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2901115856091026f);
moveline1 = Instantiate(moveline,new Vector3(3.188700871955347f,0f,0.5232333183081248f),Quaternion.Euler(0,8.760419457975459f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame79 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.7181731302182037f,0f,-0.5136017529975208f);
skate0.transform.rotation = Quaternion.Euler(0,75.0802842443682f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.7181731302182037f,0f,-0.5136017529975208f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.291284573705647f);
moveline0 = Instantiate(moveline,new Vector3(0.7181731302182037f,0f,-0.5136017529975208f),Quaternion.Euler(0,-11.911687331194983f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
skate1.transform.position = new Vector3(3.218173130218202f,0f,0.5136017529975208f);
skate1.transform.rotation = Quaternion.Euler(0,104.9197157556318f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.218173130218202f,0f,0.5136017529975208f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.291284573705647f);
moveline1 = Instantiate(moveline,new Vector3(3.218173130218202f,0f,0.5136017529975208f),Quaternion.Euler(0,-168.08831266880503f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
}
}
public class frame80 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.7481051479678823f,0f,-0.5033862211903508f);
skate0.transform.rotation = Quaternion.Euler(0,72.21549526871408f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.7481051479678823f,0f,-0.5033862211903508f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.293308779545249f);
moveline0 = Instantiate(moveline,new Vector3(0.7481051479678823f,0f,-0.5033862211903508f),Quaternion.Euler(0,165.0802842443682f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(3.248105147967881f,0f,0.5033862211903508f);
skate1.transform.rotation = Quaternion.Euler(0,107.78450473128592f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.248105147967881f,0f,0.5033862211903508f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.293308779545249f);
moveline1 = Instantiate(moveline,new Vector3(3.248105147967881f,0f,0.5033862211903508f),Quaternion.Euler(0,14.919715755631813f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame81 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.7785825903543859f,0f,-0.49255775676318053f);
skate0.transform.rotation = Quaternion.Euler(0,69.49394574184267f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.7785825903543859f,0f,-0.49255775676318053f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.295454298417349f);
moveline0 = Instantiate(moveline,new Vector3(0.7785825903543859f,0f,-0.49255775676318053f),Quaternion.Euler(0,162.21549526871408f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(3.2785825903543846f,0f,0.49255775676318053f);
skate1.transform.rotation = Quaternion.Euler(0,110.50605425815733f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.2785825903543846f,0f,0.49255775676318053f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.295454298417349f);
moveline1 = Instantiate(moveline,new Vector3(3.2785825903543846f,0f,0.49255775676318053f),Quaternion.Euler(0,17.78450473128592f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame82 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.8084344856794617f,0f,-0.4777393598899818f);
skate0.transform.rotation = Quaternion.Euler(0,66.91563566375396f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.8084344856794617f,0f,-0.4777393598899818f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2977269910284943f);
moveline0 = Instantiate(moveline,new Vector3(0.8084344856794617f,0f,-0.4777393598899818f),Quaternion.Euler(0,-20.50605425815732f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(3.3084344856794603f,0f,0.4777393598899818f);
skate1.transform.rotation = Quaternion.Euler(0,113.08436433624604f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.3084344856794603f,0f,0.4777393598899818f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2977269910284943f);
moveline1 = Instantiate(moveline,new Vector3(3.3084344856794603f,0f,0.4777393598899818f),Quaternion.Euler(0,-159.49394574184265f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame83 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.8389865347338267f,0f,-0.46224077367059485f);
skate0.transform.rotation = Quaternion.Euler(0,64.48056503444795f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.8389865347338267f,0f,-0.46224077367059485f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.300834563307582f);
moveline0 = Instantiate(moveline,new Vector3(0.8389865347338267f,0f,-0.46224077367059485f),Quaternion.Euler(0,156.91563566375396f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(3.338986534733825f,0f,0.46224077367059485f);
skate1.transform.rotation = Quaternion.Euler(0,115.51943496555205f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.338986534733825f,0f,0.46224077367059485f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.300834563307582f);
moveline1 = Instantiate(moveline,new Vector3(3.338986534733825f,0f,0.46224077367059485f),Quaternion.Euler(0,23.08436433624604f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame84 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.8703079002751548f,0f,-0.4460249686341285f);
skate0.transform.rotation = Quaternion.Euler(0,62.18873385392466f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.8703079002751548f,0f,-0.4460249686341285f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3040817388457806f);
moveline0 = Instantiate(moveline,new Vector3(0.8703079002751548f,0f,-0.4460249686341285f),Quaternion.Euler(0,154.48056503444798f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(3.370307900275153f,0f,0.4460249686341285f);
skate1.transform.rotation = Quaternion.Euler(0,117.81126614607534f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.370307900275153f,0f,0.4460249686341285f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3040817388457806f);
moveline1 = Instantiate(moveline,new Vector3(3.370307900275153f,0f,0.4460249686341285f),Quaternion.Euler(0,25.519434965552037f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame85 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.9007961219456476f,0f,-0.42905383017546833f);
skate0.transform.rotation = Quaternion.Euler(0,60.04014212218408f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.9007961219456476f,0f,-0.42905383017546833f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3074759683120958f);
moveline0 = Instantiate(moveline,new Vector3(0.9007961219456476f,0f,-0.42905383017546833f),Quaternion.Euler(0,-152.18873385392467f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(3.4007961219456457f,0f,0.42905383017546833f);
skate1.transform.rotation = Quaternion.Euler(0,119.95985787781592f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.4007961219456457f,0f,0.42905383017546833f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3074759683120958f);
moveline1 = Instantiate(moveline,new Vector3(3.4007961219456457f,0f,0.42905383017546833f),Quaternion.Euler(0,-27.81126614607531f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame86 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.9303925701708348f,0f,-0.40819447670248477f);
skate0.transform.rotation = Quaternion.Euler(0,58.03478983922619f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.9303925701708348f,0f,-0.40819447670248477f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.311024910712381f);
moveline0 = Instantiate(moveline,new Vector3(0.9303925701708348f,0f,-0.40819447670248477f),Quaternion.Euler(0,-29.959857877815935f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(3.430392570170833f,0f,0.40819447670248477f);
skate1.transform.rotation = Quaternion.Euler(0,121.96521016077381f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.430392570170833f,0f,0.40819447670248477f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.311024910712381f);
moveline1 = Instantiate(moveline,new Vector3(3.430392570170833f,0f,0.40819447670248477f),Quaternion.Euler(0,-150.04014212218408f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame87 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.9609343830997956f,0f,-0.3865011720038877f);
skate0.transform.rotation = Quaternion.Euler(0,56.17267700505102f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.9609343830997956f,0f,-0.3865011720038877f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3153823916624838f);
moveline0 = Instantiate(moveline,new Vector3(0.9609343830997956f,0f,-0.3865011720038877f),Quaternion.Euler(0,148.03478983922616f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(3.460934383099794f,0f,0.3865011720038877f);
skate1.transform.rotation = Quaternion.Euler(0,123.82732299494899f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.460934383099794f,0f,0.3865011720038877f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3153823916624838f);
moveline1 = Instantiate(moveline,new Vector3(3.460934383099794f,0f,0.3865011720038877f),Quaternion.Euler(0,31.96521016077382f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame88 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(0.992470288580483f,0f,-0.36393431386716285f);
skate0.transform.rotation = Quaternion.Euler(0,54.45380361965855f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(0.992470288580483f,0f,-0.36393431386716285f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.319909015996309f);
moveline0 = Instantiate(moveline,new Vector3(0.992470288580483f,0f,-0.36393431386716285f),Quaternion.Euler(0,146.172677005051f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(3.4924702885804813f,0f,0.36393431386716285f);
skate1.transform.rotation = Quaternion.Euler(0,125.54619638034146f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.4924702885804813f,0f,0.36393431386716285f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.319909015996309f);
moveline1 = Instantiate(moveline,new Vector3(3.4924702885804813f,0f,0.36393431386716285f),Quaternion.Euler(0,33.827322994948986f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame89 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(1.0229680526842362f,0f,-0.34045501699287645f);
skate0.transform.rotation = Quaternion.Euler(0,52.87816968304878f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(1.0229680526842362f,0f,-0.34045501699287645f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.324612738255785f);
moveline0 = Instantiate(moveline,new Vector3(1.0229680526842362f,0f,-0.34045501699287645f),Quaternion.Euler(0,-144.45380361965854f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
skate1.transform.position = new Vector3(3.5229680526842344f,0f,0.34045501699287645f);
skate1.transform.rotation = Quaternion.Euler(0,127.12183031695122f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.5229680526842344f,0f,0.34045501699287645f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.324612738255785f);
moveline1 = Instantiate(moveline,new Vector3(3.5229680526842344f,0f,0.34045501699287645f),Quaternion.Euler(0,-35.54619638034144f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
}
}
public class frame90 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(1.0523881170877556f,0f,-0.31602545702710333f);
skate0.transform.rotation = Quaternion.Euler(0,51.44577519522173f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(1.0523881170877556f,0f,-0.31602545702710333f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3295013733481675f);
moveline0 = Instantiate(moveline,new Vector3(1.0523881170877556f,0f,-0.31602545702710333f),Quaternion.Euler(0,-142.87816968304878f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(3.552388117087754f,0f,0.31602545702710333f);
skate1.transform.rotation = Quaternion.Euler(0,128.55422480477827f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.552388117087754f,0f,0.31602545702710333f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3295013733481675f);
moveline1 = Instantiate(moveline,new Vector3(3.552388117087754f,0f,0.31602545702710333f),Quaternion.Euler(0,-37.12183031695122f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame91 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(1.0829211368826694f,0f,-0.2906091758524113f);
skate0.transform.rotation = Quaternion.Euler(0,50.156620156177375f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(1.0829211368826694f,0f,-0.2906091758524113f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3345825347424969f);
moveline0 = Instantiate(moveline,new Vector3(1.0829211368826694f,0f,-0.2906091758524113f),Quaternion.Euler(0,141.44577519522173f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(3.5829211368826677f,0f,0.2906091758524113f);
skate1.transform.rotation = Quaternion.Euler(0,129.84337984382262f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.5829211368826677f,0f,0.2906091758524113f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3345825347424969f);
moveline1 = Instantiate(moveline,new Vector3(3.5829211368826677f,0f,0.2906091758524113f),Quaternion.Euler(0,38.55422480477827f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame92 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(1.1123100652496671f,0f,-0.26417135017844484f);
skate0.transform.rotation = Quaternion.Euler(0,49.01070456591573f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(1.1123100652496671f,0f,-0.26417135017844484f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3398635824688812f);
moveline0 = Instantiate(moveline,new Vector3(1.1123100652496671f,0f,-0.26417135017844484f),Quaternion.Euler(0,-140.15662015617735f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(3.6123100652496656f,0f,0.26417135017844484f);
skate1.transform.rotation = Quaternion.Euler(0,130.98929543408428f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.6123100652496656f,0f,0.26417135017844484f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3398635824688812f);
moveline1 = Instantiate(moveline,new Vector3(3.6123100652496656f,0f,0.26417135017844484f),Quaternion.Euler(0,-39.84337984382262f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame93 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(1.142870275786684f,0f,-0.23667902550094055f);
skate0.transform.rotation = Quaternion.Euler(0,48.00802842443679f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(1.142870275786684f,0f,-0.23667902550094055f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3453515804875598f);
moveline0 = Instantiate(moveline,new Vector3(1.142870275786684f,0f,-0.23667902550094055f),Quaternion.Euler(0,139.01070456591572f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(3.642870275786682f,0f,0.23667902550094055f);
skate1.transform.rotation = Quaternion.Euler(0,131.9919715755632f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.642870275786682f,0f,0.23667902550094055f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3453515804875598f);
moveline1 = Instantiate(moveline,new Vector3(3.642870275786682f,0f,0.23667902550094055f),Quaternion.Euler(0,40.98929543408427f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame94 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(1.1722357962013368f,0f,-0.2081013174581175f);
skate0.transform.rotation = Quaternion.Euler(0,47.14859173174055f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(1.1722357962013368f,0f,-0.2081013174581175f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3510532629733842f);
moveline0 = Instantiate(moveline,new Vector3(1.1722357962013368f,0f,-0.2081013174581175f),Quaternion.Euler(0,-138.0080284244368f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(3.672235796201335f,0f,0.2081013174581175f);
skate1.transform.rotation = Quaternion.Euler(0,132.85140826825943f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.672235796201335f,0f,0.2081013174581175f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3510532629733842f);
moveline1 = Instantiate(moveline,new Vector3(3.672235796201335f,0f,0.2081013174581175f),Quaternion.Euler(0,-41.99197157556321f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame95 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(1.2028157797678936f,0f,-0.1784095825150538f);
skate0.transform.rotation = Quaternion.Euler(0,46.432394487827025f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(1.2028157797678936f,0f,-0.1784095825150538f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3569750090526296f);
moveline0 = Instantiate(moveline,new Vector3(1.2028157797678936f,0f,-0.1784095825150538f),Quaternion.Euler(0,137.14859173174054f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
skate1.transform.position = new Vector3(3.702815779767892f,0f,0.1784095825150538f);
skate1.transform.rotation = Quaternion.Euler(0,133.56760551217297f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.702815779767892f,0f,0.1784095825150538f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3569750090526296f);
moveline1 = Instantiate(moveline,new Vector3(3.702815779767892f,0f,0.1784095825150538f),Quaternion.Euler(0,42.851408268259455f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
}
}
public class frame96 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(1.2346264954659911f,0f,-0.14757755975852177f);
skate0.transform.rotation = Quaternion.Euler(0,45.85943669269621f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(1.2346264954659911f,0f,-0.14757755975852177f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3631228255316388f);
moveline0 = Instantiate(moveline,new Vector3(1.2346264954659911f,0f,-0.14757755975852177f),Quaternion.Euler(0,136.43239448782703f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(3.7346264954659896f,0f,0.14757755975852177f);
skate1.transform.rotation = Quaternion.Euler(0,134.1405633073038f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.7346264954659896f,0f,0.14757755975852177f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3631228255316388f);
moveline1 = Instantiate(moveline,new Vector3(3.7346264954659896f,0f,0.14757755975852177f),Quaternion.Euler(0,43.56760551217299f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame97 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(1.2652149914253947f,0f,-0.11555944465418819f);
skate0.transform.rotation = Quaternion.Euler(0,45.42971834634809f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(1.2652149914253947f,0f,-0.11555944465418819f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3695023371696406f);
moveline0 = Instantiate(moveline,new Vector3(1.2652149914253947f,0f,-0.11555944465418819f),Quaternion.Euler(0,-135.85943669269622f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.982800669394195f);
skate1.transform.position = new Vector3(3.765214991425393f,0f,0.11555944465418819f);
skate1.transform.rotation = Quaternion.Euler(0,134.5702816536519f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.765214991425393f,0f,0.11555944465418819f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3695023371696406f);
moveline1 = Instantiate(moveline,new Vector3(3.765214991425393f,0f,0.11555944465418819f),Quaternion.Euler(0,-44.14056330730378f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.982800669394195f);
}
}
public class frame98 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(1.2970566724611572f,0f,-0.08235609170050007f);
skate0.transform.rotation = Quaternion.Euler(0,45.14323944878268f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(1.2970566724611572f,0f,-0.08235609170050007f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.376123340680672f);
moveline0 = Instantiate(moveline,new Vector3(1.2970566724611572f,0f,-0.08235609170050007f),Quaternion.Euler(0,135.42971834634807f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(3.7970566724611556f,0f,0.08235609170050007f);
skate1.transform.rotation = Quaternion.Euler(0,134.85676055121732f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.7970566724611556f,0f,0.08235609170050007f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.376123340680672f);
moveline1 = Instantiate(moveline,new Vector3(3.7970566724611556f,0f,0.08235609170050007f),Quaternion.Euler(0,44.57028165365192f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame99 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(1.3301578835082901f,0f,-0.04794896410346092f);
skate0.transform.rotation = Quaternion.Euler(0,44.99999999999997f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(1.3301578835082901f,0f,-0.04794896410346092f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3829861368671341f);
moveline0 = Instantiate(moveline,new Vector3(1.3301578835082901f,0f,-0.04794896410346092f),Quaternion.Euler(0,135.14323944878268f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(3.8301578835082886f,0f,0.04794896410346092f);
skate1.transform.rotation = Quaternion.Euler(0,135.00000000000003f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.8301578835082886f,0f,0.04794896410346092f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3829861368671341f);
moveline1 = Instantiate(moveline,new Vector3(3.8301578835082886f,0f,0.04794896410346092f),Quaternion.Euler(0,44.85676055121732f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame100 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(1.3645217852361133f,0f,-0.01232221429649389f);
skate0.transform.rotation = Quaternion.Euler(0,44.99999999999997f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(1.3645217852361133f,0f,-0.01232221429649389f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3900952187461577f);
moveline0 = Instantiate(moveline,new Vector3(1.3645217852361133f,0f,-0.01232221429649389f),Quaternion.Euler(0,134.99999999999997f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(3.8645217852361116f,0f,0.01232221429649389f);
skate1.transform.rotation = Quaternion.Euler(0,135.00000000000003f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.8645217852361116f,0f,0.01232221429649389f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3900952187461577f);
moveline1 = Instantiate(moveline,new Vector3(3.8645217852361116f,0f,0.01232221429649389f),Quaternion.Euler(0,45.000000000000036f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame101 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(1.4001483776446269f,0f,0.022394442554988056f);
skate0.transform.rotation = Quaternion.Euler(0,45.14323944878267f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(1.4001483776446269f,0f,0.022394442554988056f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.19745472611489948f);
moveline0 = Instantiate(moveline,new Vector3(1.4001483776446269f,0f,0.022394442554988056f),Quaternion.Euler(0,134.99999999999997f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(3.900148377644625f,0f,-0.022394442554988056f);
skate1.transform.rotation = Quaternion.Euler(0,134.85676055121732f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.900148377644625f,0f,-0.022394442554988056f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.19745472611489948f);
moveline1 = Instantiate(moveline,new Vector3(3.900148377644625f,0f,-0.022394442554988056f),Quaternion.Euler(0,45.000000000000036f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame102 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(1.43451544004177f,0f,0.05874234612476542f);
skate0.transform.rotation = Quaternion.Euler(0,45.42971834634808f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(1.43451544004177f,0f,0.05874234612476542f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.2046258256548863f);
moveline0 = Instantiate(moveline,new Vector3(1.43451544004177f,0f,0.05874234612476542f),Quaternion.Euler(0,-44.85676055121732f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(3.934515440041768f,0f,-0.05874234612476542f);
skate1.transform.rotation = Quaternion.Euler(0,134.57028165365193f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.934515440041768f,0f,-0.05874234612476542f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.2046258256548863f);
moveline1 = Instantiate(moveline,new Vector3(3.934515440041768f,0f,-0.05874234612476542f),Quaternion.Euler(0,-135.14323944878268f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame103 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(1.4701356875152718f,0f,0.09419693632867468f);
skate0.transform.rotation = Quaternion.Euler(0,45.8594366926962f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(1.4701356875152718f,0f,0.09419693632867468f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.21213466015600707f);
moveline0 = Instantiate(moveline,new Vector3(1.4701356875152718f,0f,0.09419693632867468f),Quaternion.Euler(0,135.42971834634807f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(3.97013568751527f,0f,-0.09419693632867468f);
skate1.transform.rotation = Quaternion.Euler(0,134.1405633073038f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(3.97013568751527f,0f,-0.09419693632867468f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.21213466015600707f);
moveline1 = Instantiate(moveline,new Vector3(3.97013568751527f,0f,-0.09419693632867468f),Quaternion.Euler(0,44.57028165365192f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame104 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(1.506999543969471f,0f,0.12876193275134726f);
skate0.transform.rotation = Quaternion.Euler(0,46.43239448782702f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(1.506999543969471f,0f,0.12876193275134726f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.21946091964737305f);
moveline0 = Instantiate(moveline,new Vector3(1.506999543969471f,0f,0.12876193275134726f),Quaternion.Euler(0,135.8594366926962f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(4.006999543969469f,0f,-0.12876193275134726f);
skate1.transform.rotation = Quaternion.Euler(0,133.56760551217297f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(4.006999543969469f,0f,-0.12876193275134726f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.21946091964737305f);
moveline1 = Instantiate(moveline,new Vector3(4.006999543969469f,0f,-0.12876193275134726f),Quaternion.Euler(0,44.1405633073038f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame105 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(1.5436613261702576f,0f,0.16351914414277485f);
skate0.transform.rotation = Quaternion.Euler(0,47.148591731740545f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(1.5436613261702576f,0f,0.16351914414277485f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.22660636276822968f);
moveline0 = Instantiate(moveline,new Vector3(1.5436613261702576f,0f,0.16351914414277485f),Quaternion.Euler(0,-136.43239448782703f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.1641902801054414f);
skate1.transform.position = new Vector3(4.043661326170255f,0f,-0.16351914414277485f);
skate1.transform.rotation = Quaternion.Euler(0,132.85140826825946f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(4.043661326170255f,0f,-0.16351914414277485f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.22660636276822968f);
moveline1 = Instantiate(moveline,new Vector3(4.043661326170255f,0f,-0.16351914414277485f),Quaternion.Euler(0,-43.567605512172975f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.1641902801054414f);
}
}
public class frame106 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(1.5815375715229485f,0f,0.1973847050119315f);
skate0.transform.rotation = Quaternion.Euler(0,48.00802842443678f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(1.5815375715229485f,0f,0.1973847050119315f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.2337956524461226f);
moveline0 = Instantiate(moveline,new Vector3(1.5815375715229485f,0f,0.1973847050119315f),Quaternion.Euler(0,137.14859173174054f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
skate1.transform.position = new Vector3(4.081537571522946f,0f,-0.1973847050119315f);
skate1.transform.rotation = Quaternion.Euler(0,131.9919715755632f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(4.081537571522946f,0f,-0.1973847050119315f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.2337956524461226f);
moveline1 = Instantiate(moveline,new Vector3(4.081537571522946f,0f,-0.1973847050119315f),Quaternion.Euler(0,42.851408268259455f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
}
}
public class frame107 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(1.6191999960559302f,0f,0.2314427367673759f);
skate0.transform.rotation = Quaternion.Euler(0,49.010704565915724f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(1.6191999960559302f,0f,0.2314427367673759f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.2408055394727322f);
moveline0 = Instantiate(moveline,new Vector3(1.6191999960559302f,0f,0.2314427367673759f),Quaternion.Euler(0,-138.0080284244368f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.1789759668273254f);
skate1.transform.position = new Vector3(4.119199996055928f,0f,-0.2314427367673759f);
skate1.transform.rotation = Quaternion.Euler(0,130.98929543408428f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(4.119199996055928f,0f,-0.2314427367673759f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.2408055394727322f);
moveline1 = Instantiate(moveline,new Vector3(4.119199996055928f,0f,-0.2314427367673759f),Quaternion.Euler(0,-41.99197157556321f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.1789759668273254f);
}
}
public class frame108 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(1.658033702758931f,0f,0.26459546350812946f);
skate0.transform.rotation = Quaternion.Euler(0,50.15662015617737f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(1.658033702758931f,0f,0.26459546350812946f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.2478613302795265f);
moveline0 = Instantiate(moveline,new Vector3(1.658033702758931f,0f,0.26459546350812946f),Quaternion.Euler(0,139.01070456591572f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(4.158033702758928f,0f,-0.26459546350812946f);
skate1.transform.rotation = Quaternion.Euler(0,129.84337984382262f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(4.158033702758928f,0f,-0.26459546350812946f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.2478613302795265f);
moveline1 = Instantiate(moveline,new Vector3(4.158033702758928f,0f,-0.26459546350812946f),Quaternion.Euler(0,40.989295434084276f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame109 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(1.6980115008898475f,0f,0.2968320076675894f);
skate0.transform.rotation = Quaternion.Euler(0,51.44577519522172f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(1.6980115008898475f,0f,0.2968320076675894f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.2547364173507193f);
moveline0 = Instantiate(moveline,new Vector3(1.6980115008898475f,0f,0.2968320076675894f),Quaternion.Euler(0,140.15662015617735f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(4.198011500889844f,0f,-0.2968320076675894f);
skate1.transform.rotation = Quaternion.Euler(0,128.55422480477827f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(4.198011500889844f,0f,-0.2968320076675894f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.2547364173507193f);
moveline1 = Instantiate(moveline,new Vector3(4.198011500889844f,0f,-0.2968320076675894f),Quaternion.Euler(0,39.84337984382264f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame110 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(1.737761763859434f,0f,0.3292498933205472f);
skate0.transform.rotation = Quaternion.Euler(0,52.87816968304878f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(1.737761763859434f,0f,0.3292498933205472f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.26142893031658215f);
moveline0 = Instantiate(moveline,new Vector3(1.737761763859434f,0f,0.3292498933205472f),Quaternion.Euler(0,-141.44577519522176f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.20444230118265033f);
skate1.transform.position = new Vector3(4.237761763859431f,0f,-0.3292498933205472f);
skate1.transform.rotation = Quaternion.Euler(0,127.12183031695122f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(4.237761763859431f,0f,-0.3292498933205472f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.26142893031658215f);
moveline1 = Instantiate(moveline,new Vector3(4.237761763859431f,0f,-0.3292498933205472f),Quaternion.Euler(0,-38.55422480477827f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.20444230118265033f);
}
}
public class frame111 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(1.778589726529254f,0f,0.3607228028190126f);
skate0.transform.rotation = Quaternion.Euler(0,54.453803619658544f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(1.778589726529254f,0f,0.3607228028190126f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.26816739559982444f);
moveline0 = Instantiate(moveline,new Vector3(1.778589726529254f,0f,0.3607228028190126f),Quaternion.Euler(0,142.87816968304878f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(4.278589726529251f,0f,-0.3607228028190126f);
skate1.transform.rotation = Quaternion.Euler(0,125.54619638034146f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(4.278589726529251f,0f,-0.3607228028190126f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.26816739559982444f);
moveline1 = Instantiate(moveline,new Vector3(4.278589726529251f,0f,-0.3607228028190126f),Quaternion.Euler(0,37.121830316951225f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame112 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(1.8204558305760083f,0f,0.39123333952586004f);
skate0.transform.rotation = Quaternion.Euler(0,56.172677005051014f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(1.8204558305760083f,0f,0.39123333952586004f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.274718281915296f);
moveline0 = Instantiate(moveline,new Vector3(1.8204558305760083f,0f,0.39123333952586004f),Quaternion.Euler(0,144.45380361965854f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(4.320455830576005f,0f,-0.39123333952586004f);
skate1.transform.rotation = Quaternion.Euler(0,123.82732299494899f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(4.320455830576005f,0f,-0.39123333952586004f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.274718281915296f);
moveline1 = Instantiate(moveline,new Vector3(4.320455830576005f,0f,-0.39123333952586004f),Quaternion.Euler(0,35.546196380341456f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame113 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(1.8633160271744893f,0f,0.42076237427304314f);
skate0.transform.rotation = Quaternion.Euler(0,58.034789839226185f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(1.8633160271744893f,0f,0.42076237427304314f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.2810779932326811f);
moveline0 = Instantiate(moveline,new Vector3(1.8633160271744893f,0f,0.42076237427304314f),Quaternion.Euler(0,146.172677005051f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(4.363316027174486f,0f,-0.42076237427304314f);
skate1.transform.rotation = Quaternion.Euler(0,121.96521016077381f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(4.363316027174486f,0f,-0.42076237427304314f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.2810779932326811f);
moveline1 = Instantiate(moveline,new Vector3(4.363316027174486f,0f,-0.42076237427304314f),Quaternion.Euler(0,33.827322994948986f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame114 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(1.9071215884767438f,0f,0.4492893960296506f);
skate0.transform.rotation = Quaternion.Euler(0,60.040142122184065f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(1.9071215884767438f,0f,0.4492893960296506f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.28724243059658555f);
moveline0 = Instantiate(moveline,new Vector3(1.9071215884767438f,0f,0.4492893960296506f),Quaternion.Euler(0,148.03478983922616f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(4.40712158847674f,0f,-0.4492893960296506f);
skate1.transform.rotation = Quaternion.Euler(0,119.95985787781594f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(4.40712158847674f,0f,-0.4492893960296506f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.28724243059658555f);
moveline1 = Instantiate(moveline,new Vector3(4.40712158847674f,0f,-0.4492893960296506f),Quaternion.Euler(0,31.96521016077382f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame115 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(1.951818923224304f,0f,0.4767929027382924f);
skate0.transform.rotation = Quaternion.Euler(0,62.18873385392466f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(1.951818923224304f,0f,0.4767929027382924f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.2932070704478959f);
moveline0 = Instantiate(moveline,new Vector3(1.951818923224304f,0f,0.4767929027382924f),Quaternion.Euler(0,150.04014212218408f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(4.451818923224301f,0f,-0.4767929027382924f);
skate1.transform.rotation = Quaternion.Euler(0,117.81126614607534f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(4.451818923224301f,0f,-0.4767929027382924f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.2932070704478959f);
moveline1 = Instantiate(moveline,new Vector3(4.451818923224301f,0f,-0.4767929027382924f),Quaternion.Euler(0,29.959857877815928f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame116 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(1.9973494018426994f,0f,0.5032508340905562f);
skate0.transform.rotation = Quaternion.Euler(0,64.48056503444795f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(1.9973494018426994f,0f,0.5032508340905562f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.2989670523118493f);
moveline0 = Instantiate(moveline,new Vector3(1.9973494018426994f,0f,0.5032508340905562f),Quaternion.Euler(0,152.18873385392465f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(4.497349401842697f,0f,-0.5032508340905562f);
skate1.transform.rotation = Quaternion.Euler(0,115.51943496555205f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(4.497349401842697f,0f,-0.5032508340905562f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.2989670523118493f);
moveline1 = Instantiate(moveline,new Vector3(4.497349401842697f,0f,-0.5032508340905562f),Quaternion.Euler(0,27.81126614607534f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame117 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(2.043649196948058f,0f,0.5286410477200555f);
skate0.transform.rotation = Quaternion.Euler(0,66.91563566375395f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(2.043649196948058f,0f,0.5286410477200555f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.3045172765332393f);
moveline0 = Instantiate(moveline,new Vector3(2.043649196948058f,0f,0.5286410477200555f),Quaternion.Euler(0,154.48056503444798f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(4.5436491969480555f,0f,-0.5286410477200555f);
skate1.transform.rotation = Quaternion.Euler(0,113.08436433624605f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(4.5436491969480555f,0f,-0.5286410477200555f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.3045172765332393f);
moveline1 = Instantiate(moveline,new Vector3(4.5436491969480555f,0f,-0.5286410477200555f),Quaternion.Euler(0,25.519434965552037f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame118 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(2.090649145782706f,0f,0.5529418398909685f);
skate0.transform.rotation = Quaternion.Euler(0,69.49394574184265f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(2.090649145782706f,0f,0.5529418398909685f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.3098525126338396f);
moveline0 = Instantiate(moveline,new Vector3(2.090649145782706f,0f,0.5529418398909685f),Quaternion.Euler(0,156.91563566375396f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(4.590649145782703f,0f,-0.5529418398909685f);
skate1.transform.rotation = Quaternion.Euler(0,110.50605425815735f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(4.590649145782703f,0f,-0.5529418398909685f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.3098525126338396f);
moveline1 = Instantiate(moveline,new Vector3(4.590649145782703f,0f,-0.5529418398909685f),Quaternion.Euler(0,23.08436433624604f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame119 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(2.1382746416787817f,0f,0.5761325112404181f);
skate0.transform.rotation = Quaternion.Euler(0,72.21549526871406f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(2.1382746416787817f,0f,0.5761325112404181f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.31496751872803175f);
moveline0 = Instantiate(moveline,new Vector3(2.1382746416787817f,0f,0.5761325112404181f),Quaternion.Euler(0,159.49394574184265f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(4.638274641678779f,0f,-0.5761325112404181f);
skate1.transform.rotation = Quaternion.Euler(0,107.78450473128594f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(4.638274641678779f,0f,-0.5761325112404181f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.31496751872803175f);
moveline1 = Instantiate(moveline,new Vector3(4.638274641678779f,0f,-0.5761325112404181f),Quaternion.Euler(0,20.50605425815735f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame120 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(2.1864455622116825f,0f,0.5981939774845818f);
skate0.transform.rotation = Quaternion.Euler(0,75.08028424436819f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(2.1864455622116825f,0f,0.5981939774845818f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.319857172257035f);
moveline0 = Instantiate(moveline,new Vector3(2.1864455622116825f,0f,0.5981939774845818f),Quaternion.Euler(0,162.21549526871405f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(4.686445562211679f,0f,-0.5981939774845818f);
skate1.transform.rotation = Quaternion.Euler(0,104.91971575563181f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(4.686445562211679f,0f,-0.5981939774845818f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.319857172257035f);
moveline1 = Instantiate(moveline,new Vector3(4.686445562211679f,0f,-0.5981939774845818f),Quaternion.Euler(0,17.78450473128595f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame121 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(2.2350762422314063f,0f,0.6191094242119951f);
skate0.transform.rotation = Quaternion.Euler(0,78.088312668805f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(2.2350762422314063f,0f,0.6191094242119951f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.32451661208813487f);
moveline0 = Instantiate(moveline,new Vector3(2.2350762422314063f,0f,0.6191094242119951f),Quaternion.Euler(0,165.0802842443682f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(4.735076242231402f,0f,-0.6191094242119951f);
skate1.transform.rotation = Quaternion.Euler(0,101.911687331195f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(4.735076242231402f,0f,-0.6191094242119951f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.32451661208813487f);
moveline1 = Instantiate(moveline,new Vector3(4.735076242231402f,0f,-0.6191094242119951f),Quaternion.Euler(0,14.919715755631813f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame122 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(2.284075500429213f,0f,0.6388650039555763f);
skate0.transform.rotation = Quaternion.Euler(0,81.23958054202454f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(2.284075500429213f,0f,0.6388650039555763f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.32894139177206283f);
moveline0 = Instantiate(moveline,new Vector3(2.284075500429213f,0f,0.6388650039555763f),Quaternion.Euler(0,168.08831266880503f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(4.784075500429209f,0f,-0.6388650039555763f);
skate1.transform.rotation = Quaternion.Euler(0,98.76041945797546f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(4.784075500429209f,0f,-0.6388650039555763f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.32894139177206283f);
moveline1 = Instantiate(moveline,new Vector3(4.784075500429209f,0f,-0.6388650039555763f),Quaternion.Euler(0,11.911687331194983f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame123 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(2.333346728485979f,0f,0.6574505726519395f);
skate0.transform.rotation = Quaternion.Euler(0,84.53408786402677f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(2.333346728485979f,0f,0.6574505726519395f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.33312764345971346f);
moveline0 = Instantiate(moveline,new Vector3(2.333346728485979f,0f,0.6574505726519395f),Quaternion.Euler(0,171.23958054202456f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(4.833346728485975f,0f,-0.6574505726519395f);
skate1.transform.rotation = Quaternion.Euler(0,95.46591213597323f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(4.833346728485975f,0f,-0.6574505726519395f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.33312764345971346f);
moveline1 = Instantiate(moveline,new Vector3(4.833346728485975f,0f,-0.6574505726519395f),Quaternion.Euler(0,8.760419457975459f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame124 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(2.382788052130497f,0f,0.6748604613598325f);
skate0.transform.rotation = Quaternion.Euler(0,87.97183463481171f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(2.382788052130497f,0f,0.6748604613598325f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.3370722516507432f);
moveline0 = Instantiate(moveline,new Vector3(2.382788052130497f,0f,0.6748604613598325f),Quaternion.Euler(0,174.5340878640268f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(4.882788052130493f,0f,-0.6748604613598325f);
skate1.transform.rotation = Quaternion.Euler(0,92.02816536518829f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(4.882788052130493f,0f,-0.6748604613598325f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.3370722516507432f);
moveline1 = Instantiate(moveline,new Vector3(4.882788052130493f,0f,-0.6748604613598325f),Quaternion.Euler(0,5.465912135973227f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame125 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(2.432292573581028f,0f,0.6910942777197854f);
skate0.transform.rotation = Quaternion.Euler(0,91.55282085437936f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(2.432292573581028f,0f,0.6910942777197854f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.3407730355850753f);
moveline0 = Instantiate(moveline,new Vector3(2.432292573581028f,0f,0.6910942777197854f),Quaternion.Euler(0,177.97183463481173f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(4.932292573581025f,0f,-0.6910942777197854f);
skate1.transform.rotation = Quaternion.Euler(0,88.44717914562064f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(4.932292573581025f,0f,-0.6910942777197854f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.3407730355850753f);
moveline1 = Instantiate(moveline,new Vector3(4.932292573581025f,0f,-0.6910942777197854f),Quaternion.Euler(0,2.0281653651882863f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame126 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(2.481748704819122f,0f,0.7033005872422282f);
skate0.transform.rotation = Quaternion.Euler(0,94.9905676251643f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(2.481748704819122f,0f,0.7033005872422282f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2557710613004762f);
moveline0 = Instantiate(moveline,new Vector3(2.481748704819122f,0f,0.7033005872422282f),Quaternion.Euler(0,-178.44717914562068f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(4.981748704819118f,0f,-0.7033005872422282f);
skate1.transform.rotation = Quaternion.Euler(0,85.0094323748357f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(4.981748704819118f,0f,-0.7033005872422282f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2557710613004762f);
moveline1 = Instantiate(moveline,new Vector3(4.981748704819118f,0f,-0.7033005872422282f),Quaternion.Euler(0,-1.5528208543793482f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame127 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(2.531049493660748f,0f,0.7114901498958836f);
skate0.transform.rotation = Quaternion.Euler(0,98.28507494716654f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(2.531049493660748f,0f,0.7114901498958836f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2531692138275488f);
moveline0 = Instantiate(moveline,new Vector3(2.531049493660748f,0f,0.7114901498958836f),Quaternion.Euler(0,-175.00943237483568f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(5.031049493660745f,0f,-0.7114901498958836f);
skate1.transform.rotation = Quaternion.Euler(0,81.71492505283346f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(5.031049493660745f,0f,-0.7114901498958836f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2531692138275488f);
moveline1 = Instantiate(moveline,new Vector3(5.031049493660745f,0f,-0.7114901498958836f),Quaternion.Euler(0,-4.990567625164303f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame128 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(2.580092963871599f,0f,0.7156779531133505f);
skate0.transform.rotation = Quaternion.Euler(0,101.43634282038606f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(2.580092963871599f,0f,0.7156779531133505f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2514219252331482f);
moveline0 = Instantiate(moveline,new Vector3(2.580092963871599f,0f,0.7156779531133505f),Quaternion.Euler(0,-171.71492505283345f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
skate1.transform.position = new Vector3(5.0800929638715955f,0f,-0.7156779531133505f);
skate1.transform.rotation = Quaternion.Euler(0,78.56365717961394f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(5.0800929638715955f,0f,-0.7156779531133505f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2514219252331482f);
moveline1 = Instantiate(moveline,new Vector3(5.0800929638715955f,0f,-0.7156779531133505f),Quaternion.Euler(0,-8.285074947166535f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
}
}
public class frame129 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(2.628782364281702f,0f,0.7158824107533398f);
skate0.transform.rotation = Quaternion.Euler(0,104.44437124482289f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(2.628782364281702f,0f,0.7158824107533398f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2505279203795072f);
moveline0 = Instantiate(moveline,new Vector3(2.628782364281702f,0f,0.7158824107533398f),Quaternion.Euler(0,-168.56365717961393f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(5.128782364281698f,0f,-0.7158824107533398f);
skate1.transform.rotation = Quaternion.Euler(0,75.55562875517711f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(5.128782364281698f,0f,-0.7158824107533398f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2505279203795072f);
moveline1 = Instantiate(moveline,new Vector3(5.128782364281698f,0f,-0.7158824107533398f),Quaternion.Euler(0,-11.436342820386045f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame130 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(2.677026336286684f,0f,0.7121245924230275f);
skate0.transform.rotation = Quaternion.Euler(0,107.309160220477f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(2.677026336286684f,0f,0.7121245924230275f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2504842641622904f);
moveline0 = Instantiate(moveline,new Vector3(2.677026336286684f,0f,0.7121245924230275f),Quaternion.Euler(0,-165.5556287551771f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(5.17702633628668f,0f,-0.7121245924230275f);
skate1.transform.rotation = Quaternion.Euler(0,72.690839779523f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(5.17702633628668f,0f,-0.7121245924230275f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2504842641622904f);
moveline1 = Instantiate(moveline,new Vector3(5.17702633628668f,0f,-0.7121245924230275f),Quaternion.Euler(0,-14.44437124482289f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame131 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(2.7247390091601993f,0f,0.7044274888209229f);
skate0.transform.rotation = Quaternion.Euler(0,110.03070974734841f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(2.7247390091601993f,0f,0.7044274888209229f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2512865080103164f);
moveline0 = Instantiate(moveline,new Vector3(2.7247390091601993f,0f,0.7044274888209229f),Quaternion.Euler(0,-162.690839779523f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(5.224739009160195f,0f,-0.7044274888209229f);
skate1.transform.rotation = Quaternion.Euler(0,69.96929025265159f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(5.224739009160195f,0f,-0.7044274888209229f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2512865080103164f);
moveline1 = Instantiate(moveline,new Vector3(5.224739009160195f,0f,-0.7044274888209229f),Quaternion.Euler(0,-17.309160220476997f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame132 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(2.771840032468618f,0f,0.6928153173093541f);
skate0.transform.rotation = Quaternion.Euler(0,112.60901982543712f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(2.771840032468618f,0f,0.6928153173093541f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2529288615614498f);
moveline0 = Instantiate(moveline,new Vector3(2.771840032468618f,0f,0.6928153173093541f),Quaternion.Euler(0,-159.96929025265163f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(5.271840032468614f,0f,-0.6928153173093541f);
skate1.transform.rotation = Quaternion.Euler(0,67.39098017456288f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(5.271840032468614f,0f,-0.6928153173093541f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2529288615614498f);
moveline1 = Instantiate(moveline,new Vector3(5.271840032468614f,0f,-0.6928153173093541f),Quaternion.Euler(0,-20.030709747348396f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame133 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(2.8182545546076305f,0f,0.6773128706298013f);
skate0.transform.rotation = Quaternion.Euler(0,115.04409045474311f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(2.8182545546076305f,0f,0.6773128706298013f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2554043863393765f);
moveline0 = Instantiate(moveline,new Vector3(2.8182545546076305f,0f,0.6773128706298013f),Quaternion.Euler(0,-157.39098017456288f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(5.318254554607626f,0f,-0.6773128706298013f);
skate1.transform.rotation = Quaternion.Euler(0,64.95590954525689f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(5.318254554607626f,0f,-0.6773128706298013f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2554043863393765f);
moveline1 = Instantiate(moveline,new Vector3(5.318254554607626f,0f,-0.6773128706298013f),Quaternion.Euler(0,-22.60901982543713f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame134 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(2.8639131561006144f,0f,0.6579449105357156f);
skate0.transform.rotation = Quaternion.Euler(0,117.33592163526642f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(2.8639131561006144f,0f,0.6579449105357156f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2587052081401389f);
moveline0 = Instantiate(moveline,new Vector3(2.8639131561006144f,0f,0.6579449105357156f),Quaternion.Euler(0,-154.9559095452569f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
skate1.transform.position = new Vector3(5.36391315610061f,0f,-0.6579449105357156f);
skate1.transform.rotation = Quaternion.Euler(0,62.664078364733584f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(5.36391315610061f,0f,-0.6579449105357156f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2587052081401389f);
moveline1 = Instantiate(moveline,new Vector3(5.36391315610061f,0f,-0.6579449105357156f),Quaternion.Euler(0,-25.044090454743127f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
}
}
public class frame135 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(2.90875174583717f,0f,0.6347356071341497f);
skate0.transform.rotation = Quaternion.Euler(0,119.484513367007f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(2.90875174583717f,0f,0.6347356071341497f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2628227448671374f);
moveline0 = Instantiate(moveline,new Vector3(2.90875174583717f,0f,0.6347356071341497f),Quaternion.Euler(0,-152.66407836473357f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(5.408751745837165f,0f,-0.6347356071341497f);
skate1.transform.rotation = Quaternion.Euler(0,60.515486632993f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(5.408751745837165f,0f,-0.6347356071341497f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2628227448671374f);
moveline1 = Instantiate(moveline,new Vector3(5.408751745837165f,0f,-0.6347356071341497f),Quaternion.Euler(0,-27.335921635266416f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame136 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(2.952711427910696f,0f,0.6077080238944053f);
skate0.transform.rotation = Quaternion.Euler(0,121.48986564996488f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(2.952711427910696f,0f,0.6077080238944053f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2677479467237853f);
moveline0 = Instantiate(moveline,new Vector3(2.952711427910696f,0f,0.6077080238944053f),Quaternion.Euler(0,-150.515486632993f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(5.452711427910691f,0f,-0.6077080238944053f);
skate1.transform.rotation = Quaternion.Euler(0,58.510134350035116f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(5.452711427910691f,0f,-0.6077080238944053f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2677479467237853f);
moveline1 = Instantiate(moveline,new Vector3(5.452711427910691f,0f,-0.6077080238944053f),Quaternion.Euler(0,-29.48451336700701f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame137 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(2.995738346156637f,0f,0.5799291210536358f);
skate0.transform.rotation = Quaternion.Euler(0,123.35197848414006f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(2.995738346156637f,0f,0.5799291210536358f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2734715459738106f);
moveline0 = Instantiate(moveline,new Vector3(2.995738346156637f,0f,0.5799291210536358f),Quaternion.Euler(0,-31.48986564996487f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(5.495738346156632f,0f,-0.5799291210536358f);
skate1.transform.rotation = Quaternion.Euler(0,56.648021515859945f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(5.495738346156632f,0f,-0.5799291210536358f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2734715459738106f);
moveline1 = Instantiate(moveline,new Vector3(5.495738346156632f,0f,-0.5799291210536358f),Quaternion.Euler(0,-148.5101343500351f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame138 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(3.0377835129154267f,0f,0.5513573028851979f);
skate0.transform.rotation = Quaternion.Euler(0,125.07085186953253f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(3.0377835129154267f,0f,0.5513573028851979f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.279341529861179f);
moveline0 = Instantiate(moveline,new Vector3(3.0377835129154267f,0f,0.5513573028851979f),Quaternion.Euler(0,-33.35197848414006f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(5.537783512915421f,0f,-0.5513573028851979f);
skate1.transform.rotation = Quaternion.Euler(0,54.929148130467475f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(5.537783512915421f,0f,-0.5513573028851979f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.279341529861179f);
moveline1 = Instantiate(moveline,new Vector3(5.537783512915421f,0f,-0.5513573028851979f),Quaternion.Euler(0,-146.64802151585994f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame139 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(3.0788026279605476f,0f,0.5190286839883929f);
skate0.transform.rotation = Quaternion.Euler(0,126.6464858061423f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(3.0788026279605476f,0f,0.5190286839883929f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2853662734354787f);
moveline0 = Instantiate(moveline,new Vector3(3.0788026279605476f,0f,0.5190286839883929f),Quaternion.Euler(0,-144.9291481304675f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(5.578802627960543f,0f,-0.5190286839883929f);
skate1.transform.rotation = Quaternion.Euler(0,53.35351419385771f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(5.578802627960543f,0f,-0.5190286839883929f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2853662734354787f);
moveline1 = Instantiate(moveline,new Vector3(5.578802627960543f,0f,-0.5190286839883929f),Quaternion.Euler(0,-35.07085186953249f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame140 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(3.1208875930572058f,0f,0.4858253598759418f);
skate0.transform.rotation = Quaternion.Euler(0,128.07888029396935f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(3.1208875930572058f,0f,0.4858253598759418f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2921683964259028f);
moveline0 = Instantiate(moveline,new Vector3(3.1208875930572058f,0f,0.4858253598759418f),Quaternion.Euler(0,36.646485806142294f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(5.620887593057201f,0f,-0.4858253598759418f);
skate1.transform.rotation = Quaternion.Euler(0,51.92111970603065f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(5.620887593057201f,0f,-0.4858253598759418f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2921683964259028f);
moveline1 = Instantiate(moveline,new Vector3(5.620887593057201f,0f,-0.4858253598759418f),Quaternion.Euler(0,143.3535141938577f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame141 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(3.161871226435358f,0f,0.4517077914956996f);
skate0.transform.rotation = Quaternion.Euler(0,129.3680353330137f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(3.161871226435358f,0f,0.4517077914956996f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.299139203069085f);
moveline0 = Instantiate(moveline,new Vector3(3.161871226435358f,0f,0.4517077914956996f),Quaternion.Euler(0,-38.07888029396932f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(5.661871226435354f,0f,-0.4517077914956996f);
skate1.transform.rotation = Quaternion.Euler(0,50.631964666986306f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(5.661871226435354f,0f,-0.4517077914956996f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.299139203069085f);
moveline1 = Instantiate(moveline,new Vector3(5.661871226435354f,0f,-0.4517077914956996f),Quaternion.Euler(0,-141.92111970603068f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame142 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(3.20172218246506f,0f,0.4166380815683875f);
skate0.transform.rotation = Quaternion.Euler(0,130.51395092327533f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(3.20172218246506f,0f,0.4166380815683875f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.3062868285556635f);
moveline0 = Instantiate(moveline,new Vector3(3.20172218246506f,0f,0.4166380815683875f),Quaternion.Euler(0,-39.368035333013694f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(5.701722182465056f,0f,-0.4166380815683875f);
skate1.transform.rotation = Quaternion.Euler(0,49.486049076724655f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(5.701722182465056f,0f,-0.4166380815683875f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.3062868285556635f);
moveline1 = Instantiate(moveline,new Vector3(5.701722182465056f,0f,-0.4166380815683875f),Quaternion.Euler(0,-140.63196466698633f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame143 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(3.2427331977447245f,0f,0.38058020857157987f);
skate0.transform.rotation = Quaternion.Euler(0,131.5166270647543f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(3.2427331977447245f,0f,0.38058020857157987f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.3136191281682383f);
moveline0 = Instantiate(moveline,new Vector3(3.2427331977447245f,0f,0.38058020857157987f),Quaternion.Euler(0,40.51395092327535f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(5.7427331977447205f,0f,-0.38058020857157987f);
skate1.transform.rotation = Quaternion.Euler(0,48.48337293524572f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(5.7427331977447205f,0f,-0.38058020857157987f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.3136191281682383f);
moveline1 = Instantiate(moveline,new Vector3(5.7427331977447205f,0f,-0.38058020857157987f),Quaternion.Euler(0,139.48604907672464f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame144 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(3.282573329745196f,0f,0.343485819649055f);
skate0.transform.rotation = Quaternion.Euler(0,132.3760637574505f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(3.282573329745196f,0f,0.343485819649055f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.3211436505404148f);
moveline0 = Instantiate(moveline,new Vector3(3.282573329745196f,0f,0.343485819649055f),Quaternion.Euler(0,-41.51662706475429f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.9892240101988279f);
skate1.transform.position = new Vector3(5.782573329745192f,0f,-0.343485819649055f);
skate1.transform.rotation = Quaternion.Euler(0,47.62393624254948f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(5.782573329745192f,0f,-0.343485819649055f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.3211436505404148f);
moveline1 = Instantiate(moveline,new Vector3(5.782573329745192f,0f,-0.343485819649055f),Quaternion.Euler(0,-138.4833729352457f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.9892240101988279f);
}
}
public class frame145 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(3.32361702215109f,0f,0.3053376206523674f);
skate0.transform.rotation = Quaternion.Euler(0,133.09226100136405f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(3.32361702215109f,0f,0.3053376206523674f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.3288706184831391f);
moveline0 = Instantiate(moveline,new Vector3(3.32361702215109f,0f,0.3053376206523674f),Quaternion.Euler(0,42.37606375745052f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(5.823617022151087f,0f,-0.3053376206523674f);
skate1.transform.rotation = Quaternion.Euler(0,46.907738998635956f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(5.823617022151087f,0f,-0.3053376206523674f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.3288706184831391f);
moveline1 = Instantiate(moveline,new Vector3(5.823617022151087f,0f,-0.3053376206523674f),Quaternion.Euler(0,137.6239362425495f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame146 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(3.3634697851581152f,0f,0.26607527132060255f);
skate0.transform.rotation = Quaternion.Euler(0,133.66521879649486f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(3.3634697851581152f,0f,0.26607527132060255f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.3368039144852397f);
moveline0 = Instantiate(moveline,new Vector3(3.3634697851581152f,0f,0.26607527132060255f),Quaternion.Euler(0,-43.09226100136405f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.9762071549622618f);
skate1.transform.position = new Vector3(5.863469785158112f,0f,-0.26607527132060255f);
skate1.transform.rotation = Quaternion.Euler(0,46.33478120350513f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(5.863469785158112f,0f,-0.26607527132060255f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.3368039144852397f);
moveline1 = Instantiate(moveline,new Vector3(5.863469785158112f,0f,-0.26607527132060255f),Quaternion.Euler(0,-136.90773899863595f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.9762071549622618f);
}
}
public class frame147 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(3.404555482824279f,0f,0.2257029753424838f);
skate0.transform.rotation = Quaternion.Euler(0,134.09493714284298f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(3.404555482824279f,0f,0.2257029753424838f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.344956532395982f);
moveline0 = Instantiate(moveline,new Vector3(3.404555482824279f,0f,0.2257029753424838f),Quaternion.Euler(0,43.66521879649487f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(5.904555482824276f,0f,-0.2257029753424838f);
skate1.transform.rotation = Quaternion.Euler(0,45.90506285715702f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(5.904555482824276f,0f,-0.2257029753424838f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.344956532395982f);
moveline1 = Instantiate(moveline,new Vector3(5.904555482824276f,0f,-0.2257029753424838f),Quaternion.Euler(0,136.33478120350514f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame148 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(3.4444334546637303f,0f,0.18416051853683174f);
skate0.transform.rotation = Quaternion.Euler(0,134.3814160404084f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(3.4444334546637303f,0f,0.18416051853683174f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.3533282453380733f);
moveline0 = Instantiate(moveline,new Vector3(3.4444334546637303f,0f,0.18416051853683174f),Quaternion.Euler(0,-44.09493714284298f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.9719438193208552f);
skate1.transform.position = new Vector3(5.944433454663727f,0f,-0.18416051853683174f);
skate1.transform.rotation = Quaternion.Euler(0,45.618583959591604f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(5.944433454663727f,0f,-0.18416051853683174f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.3533282453380733f);
moveline1 = Instantiate(moveline,new Vector3(5.944433454663727f,0f,-0.18416051853683174f),Quaternion.Euler(0,-135.90506285715702f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.9719438193208552f);
}
}
public class frame149 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(3.4855604114381524f,0f,0.1414622888108132f);
skate0.transform.rotation = Quaternion.Euler(0,134.5246554891911f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(3.4855604114381524f,0f,0.1414622888108132f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.3619324141535665f);
moveline0 = Instantiate(moveline,new Vector3(3.4855604114381524f,0f,0.1414622888108132f),Quaternion.Euler(0,44.381416040408396f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(5.985560411438149f,0f,-0.1414622888108132f);
skate1.transform.rotation = Quaternion.Euler(0,45.4753445108089f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(5.985560411438149f,0f,-0.1414622888108132f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.3619324141535665f);
moveline1 = Instantiate(moveline,new Vector3(5.985560411438149f,0f,-0.1414622888108132f),Quaternion.Euler(0,135.6185839595916f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame150 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(3.527939539864265f,0f,0.09758938332676981f);
skate0.transform.rotation = Quaternion.Euler(0,134.5246554891911f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(3.527939539864265f,0f,0.09758938332676981f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.370767192719724f);
moveline0 = Instantiate(moveline,new Vector3(3.527939539864265f,0f,0.09758938332676981f),Quaternion.Euler(0,44.5246554891911f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(6.027939539864262f,0f,-0.09758938332676981f);
skate1.transform.rotation = Quaternion.Euler(0,45.4753445108089f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(6.027939539864262f,0f,-0.09758938332676981f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.370767192719724f);
moveline1 = Instantiate(moveline,new Vector3(6.027939539864262f,0f,-0.09758938332676981f),Quaternion.Euler(0,135.4753445108089f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame151 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(3.571570839942068f,0f,0.054668461487997304f);
skate0.transform.rotation = Quaternion.Euler(0,134.3814160404084f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(3.571570839942068f,0f,0.054668461487997304f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.17983792687409247f);
moveline0 = Instantiate(moveline,new Vector3(3.571570839942068f,0f,0.054668461487997304f),Quaternion.Euler(0,44.5246554891911f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(6.071570839942065f,0f,-0.054668461487997304f);
skate1.transform.rotation = Quaternion.Euler(0,45.61858395959161f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(6.071570839942065f,0f,-0.054668461487997304f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.17983792687409247f);
moveline1 = Instantiate(moveline,new Vector3(6.071570839942065f,0f,-0.054668461487997304f),Quaternion.Euler(0,135.4753445108089f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame152 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(3.6150336908938074f,0f,0.011582689075458917f);
skate0.transform.rotation = Quaternion.Euler(0,134.09493714284298f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(3.6150336908938074f,0f,0.011582689075458917f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.18870701111410157f);
moveline0 = Instantiate(moveline,new Vector3(3.6150336908938074f,0f,0.011582689075458917f),Quaternion.Euler(0,-44.381416040408396f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.13486882135010592f);
skate1.transform.position = new Vector3(6.115033690893804f,0f,-0.011582689075458917f);
skate1.transform.rotation = Quaternion.Euler(0,45.90506285715702f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(6.115033690893804f,0f,-0.011582689075458917f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.18870701111410157f);
moveline1 = Instantiate(moveline,new Vector3(6.115033690893804f,0f,-0.011582689075458917f),Quaternion.Euler(0,-135.6185839595916f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.13486882135010592f);
}
}
public class frame153 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(3.6597391299485884f,0f,-0.030573475649429777f);
skate0.transform.rotation = Quaternion.Euler(0,133.66521879649486f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(3.6597391299485884f,0f,-0.030573475649429777f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.19760748318482668f);
moveline0 = Instantiate(moveline,new Vector3(3.6597391299485884f,0f,-0.030573475649429777f),Quaternion.Euler(0,44.09493714284298f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(6.159739129948584f,0f,0.030573475649429777f);
skate1.transform.rotation = Quaternion.Euler(0,46.33478120350514f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(6.159739129948584f,0f,0.030573475649429777f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.19760748318482668f);
moveline1 = Instantiate(moveline,new Vector3(6.159739129948584f,0f,0.030573475649429777f),Quaternion.Euler(0,135.90506285715702f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame154 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(3.7042605587766206f,0f,-0.07290527077936285f);
skate0.transform.rotation = Quaternion.Euler(0,133.09226100136402f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(3.7042605587766206f,0f,-0.07290527077936285f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.20631535591089292f);
moveline0 = Instantiate(moveline,new Vector3(3.7042605587766206f,0f,-0.07290527077936285f),Quaternion.Euler(0,-43.665218796494855f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.14924572473057798f);
skate1.transform.position = new Vector3(6.204260558776617f,0f,0.07290527077936285f);
skate1.transform.rotation = Quaternion.Euler(0,46.90773899863596f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(6.204260558776617f,0f,0.07290527077936285f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.20631535591089292f);
moveline1 = Instantiate(moveline,new Vector3(6.204260558776617f,0f,0.07290527077936285f),Quaternion.Euler(0,-136.33478120350514f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.14924572473057798f);
}
}
public class frame155 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(3.7485903944980743f,0f,-0.11541630703315749f);
skate0.transform.rotation = Quaternion.Euler(0,132.3760637574505f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(3.7485903944980743f,0f,-0.11541630703315749f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.21506095584332585f);
moveline0 = Instantiate(moveline,new Vector3(3.7485903944980743f,0f,-0.11541630703315749f),Quaternion.Euler(0,-43.09226100136402f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.15704924377642965f);
skate1.transform.position = new Vector3(6.24859039449807f,0f,0.11541630703315749f);
skate1.transform.rotation = Quaternion.Euler(0,47.62393624254949f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(6.24859039449807f,0f,0.11541630703315749f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.21506095584332585f);
moveline1 = Instantiate(moveline,new Vector3(6.24859039449807f,0f,0.11541630703315749f),Quaternion.Euler(0,-136.90773899863598f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.15704924377642965f);
}
}
public class frame156 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(3.7941237906249508f,0f,-0.15700789702040158f);
skate0.transform.rotation = Quaternion.Euler(0,131.5166270647543f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(3.7941237906249508f,0f,-0.15700789702040158f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.2238470676837291f);
moveline0 = Instantiate(moveline,new Vector3(3.7941237906249508f,0f,-0.15700789702040158f),Quaternion.Euler(0,42.37606375745052f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(6.294123790624947f,0f,0.15700789702040158f);
skate1.transform.rotation = Quaternion.Euler(0,48.483372935245725f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(6.294123790624947f,0f,0.15700789702040158f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.2238470676837291f);
moveline1 = Instantiate(moveline,new Vector3(6.294123790624947f,0f,0.15700789702040158f),Quaternion.Euler(0,137.6239362425495f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame157 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(3.840840824903673f,0f,-0.19767749608256238f);
skate0.transform.rotation = Quaternion.Euler(0,130.51395092327533f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(3.840840824903673f,0f,-0.19767749608256238f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.23244848084202227f);
moveline0 = Instantiate(moveline,new Vector3(3.840840824903673f,0f,-0.19767749608256238f),Quaternion.Euler(0,41.51662706475428f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(6.340840824903669f,0f,0.19767749608256238f);
skate1.transform.rotation = Quaternion.Euler(0,49.48604907672466f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(6.340840824903669f,0f,0.19767749608256238f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.23244848084202227f);
moveline1 = Instantiate(moveline,new Vector3(6.340840824903669f,0f,0.19767749608256238f),Quaternion.Euler(0,138.4833729352457f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame158 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(3.887345431478567f,0f,-0.23852861501636805f);
skate0.transform.rotation = Quaternion.Euler(0,129.3680353330137f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(3.887345431478567f,0f,-0.23852861501636805f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.24086616947763692f);
moveline0 = Instantiate(moveline,new Vector3(3.887345431478567f,0f,-0.23852861501636805f),Quaternion.Euler(0,-40.51395092327536f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.18311797766799312f);
skate1.transform.position = new Vector3(6.387345431478563f,0f,0.23852861501636805f);
skate1.transform.rotation = Quaternion.Euler(0,50.631964666986306f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(6.387345431478563f,0f,0.23852861501636805f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.24086616947763692f);
moveline1 = Instantiate(moveline,new Vector3(6.387345431478563f,0f,0.23852861501636805f),Quaternion.Euler(0,-139.48604907672464f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.18311797766799312f);
}
}
public class frame159 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(3.9349827154019112f,0f,-0.27844445289477693f);
skate0.transform.rotation = Quaternion.Euler(0,128.07888029396935f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(3.9349827154019112f,0f,-0.27844445289477693f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.24933017117427467f);
moveline0 = Instantiate(moveline,new Vector3(3.9349827154019112f,0f,-0.27844445289477693f),Quaternion.Euler(0,39.368035333013694f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(6.434982715401907f,0f,0.27844445289477693f);
skate1.transform.rotation = Quaternion.Euler(0,51.92111970603066f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(6.434982715401907f,0f,0.27844445289477693f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.24933017117427467f);
moveline1 = Instantiate(moveline,new Vector3(6.434982715401907f,0f,0.27844445289477693f),Quaternion.Euler(0,140.6319646669863f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame160 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(3.9837213310437614f,0f,-0.3174146625459048f);
skate0.transform.rotation = Quaternion.Euler(0,126.64648580614228f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(3.9837213310437614f,0f,-0.3174146625459048f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.2576106058287142f);
moveline0 = Instantiate(moveline,new Vector3(3.9837213310437614f,0f,-0.3174146625459048f),Quaternion.Euler(0,38.07888029396934f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(6.483721331043758f,0f,0.3174146625459048f);
skate1.transform.rotation = Quaternion.Euler(0,53.35351419385772f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(6.483721331043758f,0f,0.3174146625459048f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.2576106058287142f);
moveline1 = Instantiate(moveline,new Vector3(6.483721331043758f,0f,0.3174146625459048f),Quaternion.Euler(0,141.92111970603065f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame161 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(4.033525796737149f,0f,-0.3554266093305715f);
skate0.transform.rotation = Quaternion.Euler(0,125.07085186953252f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(4.033525796737149f,0f,-0.3554266093305715f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.2657062704459066f);
moveline0 = Instantiate(moveline,new Vector3(4.033525796737149f,0f,-0.3554266093305715f),Quaternion.Euler(0,36.64648580614229f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(6.533525796737146f,0f,0.3554266093305715f);
skate1.transform.rotation = Quaternion.Euler(0,54.92914813046748f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(6.533525796737146f,0f,0.3554266093305715f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.2657062704459066f);
moveline1 = Instantiate(moveline,new Vector3(6.533525796737146f,0f,0.3554266093305715f),Quaternion.Euler(0,143.3535141938577f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame162 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(4.084356314144205f,0f,-0.3924656509927424f);
skate0.transform.rotation = Quaternion.Euler(0,123.35197848414005f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(4.084356314144205f,0f,-0.3924656509927424f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.27361526585240153f);
moveline0 = Instantiate(moveline,new Vector3(4.084356314144205f,0f,-0.3924656509927424f),Quaternion.Euler(0,35.07085186953252f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(6.584356314144202f,0f,0.3924656509927424f);
skate1.transform.rotation = Quaternion.Euler(0,56.64802151585995f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(6.584356314144202f,0f,0.3924656509927424f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.27361526585240153f);
moveline1 = Instantiate(moveline,new Vector3(6.584356314144202f,0f,0.3924656509927424f),Quaternion.Euler(0,144.92914813046747f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame163 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(4.136168583038413f,0f,-0.4285154535729017f);
skate0.transform.rotation = Quaternion.Euler(0,121.48986564996487f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(4.136168583038413f,0f,-0.4285154535729017f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.28133506044040313f);
moveline0 = Instantiate(moveline,new Vector3(4.136168583038413f,0f,-0.4285154535729017f),Quaternion.Euler(0,33.35197848414005f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(6.636168583038409f,0f,0.4285154535729017f);
skate1.transform.rotation = Quaternion.Euler(0,58.51013435003513f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(6.636168583038409f,0f,0.4285154535729017f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.28133506044040313f);
moveline1 = Instantiate(moveline,new Vector3(6.636168583038409f,0f,0.4285154535729017f),Quaternion.Euler(0,146.64802151585997f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame164 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(4.188913615760205f,0f,-0.4635583454241312f);
skate0.transform.rotation = Quaternion.Euler(0,119.484513367007f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(4.188913615760205f,0f,-0.4635583454241312f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.2888625611990836f);
moveline0 = Instantiate(moveline,new Vector3(4.188913615760205f,0f,-0.4635583454241312f),Quaternion.Euler(0,31.489865649964877f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(6.688913615760201f,0f,0.4635583454241312f);
skate1.transform.rotation = Quaternion.Euler(0,60.51548663299301f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(6.688913615760201f,0f,0.4635583454241312f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.2888625611990836f);
moveline1 = Instantiate(moveline,new Vector3(6.688913615760201f,0f,0.4635583454241312f),Quaternion.Euler(0,148.51013435003512f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame165 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(4.2425375561450265f,0f,-0.49757571125808603f);
skate0.transform.rotation = Quaternion.Euler(0,117.3359216352664f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(4.2425375561450265f,0f,-0.49757571125808603f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.2961941929823797f);
moveline0 = Instantiate(moveline,new Vector3(4.2425375561450265f,0f,-0.49757571125808603f),Quaternion.Euler(0,29.484513367006983f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(6.742537556145023f,0f,0.49757571125808603f);
skate1.transform.rotation = Quaternion.Euler(0,62.6640783647336f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(6.742537556145023f,0f,0.49757571125808603f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.2961941929823797f);
moveline1 = Instantiate(moveline,new Vector3(6.742537556145023f,0f,0.49757571125808603f),Quaternion.Euler(0,150.51548663299303f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame166 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(4.296981508286277f,0f,-0.5305484279484646f);
skate0.transform.rotation = Quaternion.Euler(0,115.0440904547431f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(4.296981508286277f,0f,-0.5305484279484646f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.30332598691908286f);
moveline0 = Instantiate(moveline,new Vector3(4.296981508286277f,0f,-0.5305484279484646f),Quaternion.Euler(0,27.335921635266402f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(6.796981508286273f,0f,0.5305484279484646f);
skate1.transform.rotation = Quaternion.Euler(0,64.9559095452569f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(6.796981508286273f,0f,0.5305484279484646f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.30332598691908286f);
moveline1 = Instantiate(moveline,new Vector3(6.796981508286273f,0f,0.5305484279484646f),Quaternion.Euler(0,152.6640783647336f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame167 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(4.352181381073556f,0f,-0.5624573435224203f);
skate0.transform.rotation = Quaternion.Euler(0,112.6090198254371f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(4.352181381073556f,0f,-0.5624573435224203f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.31025367880151f);
moveline0 = Instantiate(moveline,new Vector3(4.352181381073556f,0f,-0.5624573435224203f),Quaternion.Euler(0,25.044090454743113f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(6.852181381073552f,0f,0.5624573435224203f);
skate1.transform.rotation = Quaternion.Euler(0,67.3909801745629f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(6.852181381073552f,0f,0.5624573435224203f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.31025367880151f);
moveline1 = Instantiate(moveline,new Vector3(6.852181381073552f,0f,0.5624573435224203f),Quaternion.Euler(0,154.95590954525687f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame168 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(4.408067755030241f,0f,-0.5932838003650496f);
skate0.transform.rotation = Quaternion.Euler(0,110.0307097473484f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(4.408067755030241f,0f,-0.5932838003650496f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.3169728181888919f);
moveline0 = Instantiate(moveline,new Vector3(4.408067755030241f,0f,-0.5932838003650496f),Quaternion.Euler(0,22.6090198254371f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(6.908067755030237f,0f,0.5932838003650496f);
skate1.transform.rotation = Quaternion.Euler(0,69.9692902526516f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(6.908067755030237f,0f,0.5932838003650496f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.3169728181888919f);
moveline1 = Instantiate(moveline,new Vector3(6.908067755030237f,0f,0.5932838003650496f),Quaternion.Euler(0,157.3909801745629f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame169 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(4.464565778552022f,0f,-0.6230102031381936f);
skate0.transform.rotation = Quaternion.Euler(0,107.30916022047698f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(4.464565778552022f,0f,-0.6230102031381936f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.3234788888266477f);
moveline0 = Instantiate(moveline,new Vector3(4.464565778552022f,0f,-0.6230102031381936f),Quaternion.Euler(0,20.030709747348396f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(6.964565778552019f,0f,0.6230102031381936f);
skate1.transform.rotation = Quaternion.Euler(0,72.69083977952302f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(6.964565778552019f,0f,0.6230102031381936f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.3234788888266477f);
moveline1 = Instantiate(moveline,new Vector3(6.964565778552019f,0f,0.6230102031381936f),Quaternion.Euler(0,159.9692902526516f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame170 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(4.52159510120527f,0f,-0.6516206312624373f);
skate0.transform.rotation = Quaternion.Euler(0,104.44437124482286f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(4.52159510120527f,0f,-0.6516206312624373f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.3297674408092469f);
moveline0 = Instantiate(moveline,new Vector3(4.52159510120527f,0f,-0.6516206312624373f),Quaternion.Euler(0,17.309160220476983f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(7.021595101205267f,0f,0.6516206312624373f);
skate1.transform.rotation = Quaternion.Euler(0,75.55562875517714f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(7.021595101205267f,0f,0.6516206312624373f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.3297674408092469f);
moveline1 = Instantiate(moveline,new Vector3(7.021595101205267f,0f,0.6516206312624373f),Quaternion.Euler(0,162.690839779523f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame171 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(4.57906985226364f,0f,-0.6791014950214898f);
skate0.transform.rotation = Quaternion.Euler(0,101.43634282038605f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(4.57906985226364f,0f,-0.6791014950214898f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.33583423469952056f);
moveline0 = Instantiate(moveline,new Vector3(4.57906985226364f,0f,-0.6791014950214898f),Quaternion.Euler(0,14.444371244822861f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(7.079069852263636f,0f,0.6791014950214898f);
skate1.transform.rotation = Quaternion.Euler(0,78.56365717961395f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(7.079069852263636f,0f,0.6791014950214898f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.33583423469952056f);
moveline1 = Instantiate(moveline,new Vector3(7.079069852263636f,0f,0.6791014950214898f),Quaternion.Euler(0,165.55562875517714f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame172 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(4.636898673122757f,0f,-0.7054422334136697f);
skate0.transform.rotation = Quaternion.Euler(0,98.28507494716652f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(4.636898673122757f,0f,-0.7054422334136697f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.3416753975593141f);
moveline0 = Instantiate(moveline,new Vector3(4.636898673122757f,0f,-0.7054422334136697f),Quaternion.Euler(0,11.436342820386045f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(7.1368986731227535f,0f,0.7054422334136697f);
skate1.transform.rotation = Quaternion.Euler(0,81.71492505283348f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(7.1368986731227535f,0f,0.7054422334136697f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.3416753975593141f);
moveline1 = Instantiate(moveline,new Vector3(7.1368986731227535f,0f,0.7054422334136697f),Quaternion.Euler(0,168.56365717961395f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame173 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(4.69498481261265f,0f,-0.7306360507906935f);
skate0.transform.rotation = Quaternion.Euler(0,94.99056762516427f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(4.69498481261265f,0f,-0.7306360507906935f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.3472875905449214f);
moveline0 = Instantiate(moveline,new Vector3(4.69498481261265f,0f,-0.7306360507906935f),Quaternion.Euler(0,8.285074947166521f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(7.194984812612646f,0f,0.7306360507906935f);
skate1.transform.rotation = Quaternion.Euler(0,85.00943237483573f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(7.194984812612646f,0f,0.7306360507906935f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.3472875905449214f);
moveline1 = Instantiate(moveline,new Vector3(7.194984812612646f,0f,0.7306360507906935f),Quaternion.Euler(0,171.71492505283348f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame174 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(4.75322629449901f,0f,-0.7546806880867953f);
skate0.transform.rotation = Quaternion.Euler(0,91.55282085437933f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(4.75322629449901f,0f,-0.7546806880867953f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.35266818737716166f);
moveline0 = Instantiate(moveline,new Vector3(4.75322629449901f,0f,-0.7546806880867953f),Quaternion.Euler(0,4.9905676251642745f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(7.253226294499006f,0f,0.7546806880867953f);
skate1.transform.rotation = Quaternion.Euler(0,88.44717914562067f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(7.253226294499006f,0f,0.7546806880867953f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.35266818737716166f);
moveline1 = Instantiate(moveline,new Vector3(7.253226294499006f,0f,0.7546806880867953f),Quaternion.Euler(0,175.00943237483574f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame175 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(4.811516166597807f,0f,-0.7775792230523765f);
skate0.transform.rotation = Quaternion.Euler(0,87.97183463481169f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(4.811516166597807f,0f,-0.7775792230523765f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.35781546261358904f);
moveline0 = Instantiate(moveline,new Vector3(4.811516166597807f,0f,-0.7775792230523765f),Quaternion.Euler(0,1.552820854379334f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(7.311516166597803f,0f,0.7775792230523765f);
skate1.transform.rotation = Quaternion.Euler(0,92.02816536518831f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(7.311516166597803f,0f,0.7775792230523765f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.35781546261358904f);
moveline1 = Instantiate(moveline,new Vector3(7.311516166597803f,0f,0.7775792230523765f),Quaternion.Euler(0,178.44717914562068f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame176 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(4.869742840890591f,0f,-0.7964837495140347f);
skate0.transform.rotation = Quaternion.Euler(0,84.53408786402674f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(4.869742840890591f,0f,-0.7964837495140347f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2372712117653688f);
moveline0 = Instantiate(moveline,new Vector3(4.869742840890591f,0f,-0.7964837495140347f),Quaternion.Euler(0,-2.0281653651883005f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(7.369742840890588f,0f,0.7964837495140347f);
skate1.transform.rotation = Quaternion.Euler(0,95.46591213597326f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(7.369742840890588f,0f,0.7964837495140347f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2372712117653688f);
moveline1 = Instantiate(moveline,new Vector3(7.369742840890588f,0f,0.7964837495140347f),Quaternion.Euler(0,-177.97183463481167f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame177 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(4.927799419595624f,0f,-0.811408527282749f);
skate0.transform.rotation = Quaternion.Euler(0,81.23958054202451f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(4.927799419595624f,0f,-0.811408527282749f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2332062228544225f);
moveline0 = Instantiate(moveline,new Vector3(4.927799419595624f,0f,-0.811408527282749f),Quaternion.Euler(0,-5.465912135973255f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(7.427799419595621f,0f,0.811408527282749f);
skate1.transform.rotation = Quaternion.Euler(0,98.76041945797549f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(7.427799419595621f,0f,0.811408527282749f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2332062228544225f);
moveline1 = Instantiate(moveline,new Vector3(7.427799419595621f,0f,0.811408527282749f),Quaternion.Euler(0,-174.53408786402673f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame178 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(4.985584028441697f,0f,-0.8223720101668549f);
skate0.transform.rotation = Quaternion.Euler(0,78.08831266880499f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(4.985584028441697f,0f,-0.8223720101668549f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2299913054789726f);
moveline0 = Instantiate(moveline,new Vector3(4.985584028441697f,0f,-0.8223720101668549f),Quaternion.Euler(0,-8.760419457975473f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(7.485584028441694f,0f,0.8223720101668549f);
skate1.transform.rotation = Quaternion.Euler(0,101.91168733119501f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(7.485584028441694f,0f,0.8223720101668549f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2299913054789726f);
moveline1 = Instantiate(moveline,new Vector3(7.485584028441694f,0f,0.8223720101668549f),Quaternion.Euler(0,-171.23958054202456f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame179 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(5.043000059109687f,0f,-0.8293960406894695f);
skate0.transform.rotation = Quaternion.Euler(0,75.08028424436816f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(5.043000059109687f,0f,-0.8293960406894695f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2276264197170819f);
moveline0 = Instantiate(moveline,new Vector3(5.043000059109687f,0f,-0.8293960406894695f),Quaternion.Euler(0,-11.911687331195012f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
skate1.transform.position = new Vector3(7.5430000591096835f,0f,0.8293960406894695f);
skate1.transform.rotation = Quaternion.Euler(0,104.91971575563184f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(7.5430000591096835f,0f,0.8293960406894695f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2276264197170819f);
moveline1 = Instantiate(moveline,new Vector3(7.5430000591096835f,0f,0.8293960406894695f),Quaternion.Euler(0,-168.08831266880497f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
}
}
public class frame180 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(5.099956330290854f,0f,-0.8325050759217703f);
skate0.transform.rotation = Quaternion.Euler(0,72.21549526871405f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(5.099956330290854f,0f,-0.8325050759217703f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2261098211073527f);
moveline0 = Instantiate(moveline,new Vector3(5.099956330290854f,0f,-0.8325050759217703f),Quaternion.Euler(0,-14.919715755631842f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(7.59995633029085f,0f,0.8325050759217703f);
skate1.transform.rotation = Quaternion.Euler(0,107.78450473128595f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(7.59995633029085f,0f,0.8325050759217703f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2261098211073527f);
moveline1 = Instantiate(moveline,new Vector3(7.59995633029085f,0f,0.8325050759217703f),Quaternion.Euler(0,-165.0802842443682f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame181 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(5.156367176835196f,0f,-0.8317254500982058f);
skate0.transform.rotation = Quaternion.Euler(0,69.49394574184264f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(5.156367176835196f,0f,-0.8317254500982058f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2254381600674085f);
moveline0 = Instantiate(moveline,new Vector3(5.156367176835196f,0f,-0.8317254500982058f),Quaternion.Euler(0,-17.78450473128595f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(7.656367176835192f,0f,0.8317254500982058f);
skate1.transform.rotation = Quaternion.Euler(0,110.50605425815736f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(7.656367176835192f,0f,0.8317254500982058f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2254381600674085f);
moveline1 = Instantiate(moveline,new Vector3(7.656367176835192f,0f,0.8317254500982058f),Quaternion.Euler(0,-162.21549526871402f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame182 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(5.21215247631811f,0f,-0.8270846782265354f);
skate0.transform.rotation = Quaternion.Euler(0,66.91563566375393f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(5.21215247631811f,0f,-0.8270846782265354f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2256066081917725f);
moveline0 = Instantiate(moveline,new Vector3(5.21215247631811f,0f,-0.8270846782265354f),Quaternion.Euler(0,-20.506054258157377f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(7.712152476318106f,0f,0.8270846782265354f);
skate1.transform.rotation = Quaternion.Euler(0,113.08436433624607f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(7.712152476318106f,0f,0.8270846782265354f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2256066081917725f);
moveline1 = Instantiate(moveline,new Vector3(7.712152476318106f,0f,0.8270846782265354f),Quaternion.Euler(0,-159.49394574184265f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame183 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(5.267237622071735f,0f,-0.8186108036081655f);
skate0.transform.rotation = Quaternion.Euler(0,64.48056503444792f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(5.267237622071735f,0f,-0.8186108036081655f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2266090087095538f);
moveline0 = Instantiate(moveline,new Vector3(5.267237622071735f,0f,-0.8186108036081655f),Quaternion.Euler(0,-23.084364336246068f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(7.767237622071732f,0f,0.8186108036081655f);
skate1.transform.rotation = Quaternion.Euler(0,115.51943496555208f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(7.767237622071732f,0f,0.8186108036081655f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2266090087095538f);
moveline1 = Instantiate(moveline,new Vector3(7.767237622071732f,0f,0.8186108036081655f),Quaternion.Euler(0,-156.91563566375396f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame184 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(5.3215534513383975f,0f,-0.8063317910444454f);
skate0.transform.rotation = Quaternion.Euler(0,62.18873385392463f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(5.3215534513383975f,0f,-0.8063317910444454f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2284380481148507f);
moveline0 = Instantiate(moveline,new Vector3(5.3215534513383975f,0f,-0.8063317910444454f),Quaternion.Euler(0,-25.519434965552065f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
skate1.transform.position = new Vector3(7.821553451338394f,0f,0.8063317910444454f);
skate1.transform.rotation = Quaternion.Euler(0,117.81126614607537f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(7.821553451338394f,0f,0.8063317910444454f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2284380481148507f);
moveline1 = Instantiate(moveline,new Vector3(7.821553451338394f,0f,0.8063317910444454f),Quaternion.Euler(0,-154.48056503444792f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
}
}
public class frame185 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(5.3750361367342245f,0f,-0.7902749665204963f);
skate0.transform.rotation = Quaternion.Euler(0,60.040142122184044f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(5.3750361367342245f,0f,-0.7902749665204963f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2310854458446543f);
moveline0 = Instantiate(moveline,new Vector3(5.3750361367342245f,0f,-0.7902749665204963f),Quaternion.Euler(0,-27.81126614607537f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(7.875036136734221f,0f,0.7902749665204963f);
skate1.transform.rotation = Quaternion.Euler(0,119.95985787781595f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(7.875036136734221f,0f,0.7902749665204963f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2310854458446543f);
moveline1 = Instantiate(moveline,new Vector3(7.875036136734221f,0f,0.7902749665204963f),Quaternion.Euler(0,-152.18873385392465f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame186 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(5.427627048684745f,0f,-0.7704665033247962f);
skate0.transform.rotation = Quaternion.Euler(0,58.034789839226164f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(5.427627048684745f,0f,-0.7704665033247962f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2345421588719212f);
moveline0 = Instantiate(moveline,new Vector3(5.427627048684745f,0f,-0.7704665033247962f),Quaternion.Euler(0,-29.959857877815935f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
skate1.transform.position = new Vector3(7.927627048684742f,0f,0.7704665033247962f);
skate1.transform.rotation = Quaternion.Euler(0,121.96521016077384f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(7.927627048684742f,0f,0.7704665033247962f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2345421588719212f);
moveline1 = Instantiate(moveline,new Vector3(7.927627048684742f,0f,0.7704665033247962f),Quaternion.Euler(0,-150.04014212218408f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
}
}
public class frame187 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(5.4792725959314925f,0f,-0.7469309538728106f);
skate0.transform.rotation = Quaternion.Euler(0,56.172677005050986f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(5.4792725959314925f,0f,-0.7469309538728106f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2387985982008574f);
moveline0 = Instantiate(moveline,new Vector3(5.4792725959314925f,0f,-0.7469309538728106f),Quaternion.Euler(0,-31.96521016077382f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(7.979272595931489f,0f,0.7469309538728106f);
skate1.transform.rotation = Quaternion.Euler(0,123.82732299494901f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(7.979272595931489f,0f,0.7469309538728106f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2387985982008574f);
moveline1 = Instantiate(moveline,new Vector3(7.979272595931489f,0f,0.7469309538728106f),Quaternion.Euler(0,-148.0347898392262f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame188 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(5.529924050626513f,0f,-0.7196908259473738f);
skate0.transform.rotation = Quaternion.Euler(0,54.453803619658515f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(5.529924050626513f,0f,-0.7196908259473738f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.243844854488034f);
moveline0 = Instantiate(moveline,new Vector3(5.529924050626513f,0f,-0.7196908259473738f),Quaternion.Euler(0,-33.827322994948986f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(8.02992405062651f,0f,0.7196908259473738f);
skate1.transform.rotation = Quaternion.Euler(0,125.54619638034148f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(8.02992405062651f,0f,0.7196908259473738f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.243844854488034f);
moveline1 = Instantiate(moveline,new Vector3(8.02992405062651f,0f,0.7196908259473738f),Quaternion.Euler(0,-146.172677005051f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame189 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(5.579537363944599f,0f,-0.688766201636981f);
skate0.transform.rotation = Quaternion.Euler(0,52.87816968304875f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(5.579537363944599f,0f,-0.688766201636981f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.249670930353989f);
moveline0 = Instantiate(moveline,new Vector3(5.579537363944599f,0f,-0.688766201636981f),Quaternion.Euler(0,-35.546196380341485f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(8.079537363944597f,0f,0.688766201636981f);
skate1.transform.rotation = Quaternion.Euler(0,127.12183031695125f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(8.079537363944597f,0f,0.688766201636981f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.249670930353989f);
moveline1 = Instantiate(moveline,new Vector3(8.079537363944597f,0f,0.688766201636981f),Quaternion.Euler(0,-144.4538036196585f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame190 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(5.628072977562452f,0f,-0.6541743969346301f);
skate0.transform.rotation = Quaternion.Euler(0,51.44577519522169f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(5.628072977562452f,0f,-0.6541743969346301f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.256266977380928f);
moveline0 = Instantiate(moveline,new Vector3(5.628072977562452f,0f,-0.6541743969346301f),Quaternion.Euler(0,-37.12183031695122f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(8.12807297756245f,0f,0.6541743969346301f);
skate1.transform.rotation = Quaternion.Euler(0,128.5542248047783f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(8.12807297756245f,0f,0.6541743969346301f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.256266977380928f);
moveline1 = Instantiate(moveline,new Vector3(8.12807297756245f,0f,0.6541743969346301f),Quaternion.Euler(0,-142.87816968304878f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame191 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(5.67549563578891f,0f,-0.6159296597429111f);
skate0.transform.rotation = Quaternion.Euler(0,50.15662015617735f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(5.67549563578891f,0f,-0.6159296597429111f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.263623536298198f);
moveline0 = Instantiate(moveline,new Vector3(5.67549563578891f,0f,-0.6159296597429111f),Quaternion.Euler(0,-38.5542248047783f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(8.17549563578891f,0f,0.6159296597429111f);
skate1.transform.rotation = Quaternion.Euler(0,129.84337984382265f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(8.17549563578891f,0f,0.6159296597429111f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.263623536298198f);
moveline1 = Instantiate(moveline,new Vector3(8.17549563578891f,0f,0.6159296597429111f),Quaternion.Euler(0,-141.4457751952217f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame192 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(5.7217742025874525f,0f,-0.574042903904228f);
skate0.transform.rotation = Quaternion.Euler(0,49.010704565915695f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(5.7217742025874525f,0f,-0.574042903904228f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2717317794247665f);
moveline0 = Instantiate(moveline,new Vector3(5.7217742025874525f,0f,-0.574042903904228f),Quaternion.Euler(0,-39.843379843822646f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(8.221774202587453f,0f,0.574042903904228f);
skate1.transform.rotation = Quaternion.Euler(0,130.9892954340843f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(8.221774202587453f,0f,0.574042903904228f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2717317794247665f);
moveline1 = Instantiate(moveline,new Vector3(8.221774202587453f,0f,0.574042903904228f),Quaternion.Euler(0,-140.15662015617735f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame193 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(5.769224051556014f,0f,-0.5312173058931349f);
skate0.transform.rotation = Quaternion.Euler(0,48.00802842443676f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(5.769224051556014f,0f,-0.5312173058931349f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.280583755055925f);
moveline0 = Instantiate(moveline,new Vector3(5.769224051556014f,0f,-0.5312173058931349f),Quaternion.Euler(0,139.0107045659157f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(8.269224051556014f,0f,0.5312173058931349f);
skate1.transform.rotation = Quaternion.Euler(0,131.99197157556324f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(8.269224051556014f,0f,0.5312173058931349f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.280583755055925f);
moveline1 = Instantiate(moveline,new Vector3(8.269224051556014f,0f,0.5312173058931349f),Quaternion.Euler(0,40.989295434084305f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame194 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(5.815528808376204f,0f,-0.48736095278074687f);
skate0.transform.rotation = Quaternion.Euler(0,47.148591731740524f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(5.815528808376204f,0f,-0.48736095278074687f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2896056282533592f);
moveline0 = Instantiate(moveline,new Vector3(5.815528808376204f,0f,-0.48736095278074687f),Quaternion.Euler(0,-138.00802842443676f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.9584846538330613f);
skate1.transform.position = new Vector3(8.315528808376204f,0f,0.48736095278074687f);
skate1.transform.rotation = Quaternion.Euler(0,132.8514082682595f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(8.315528808376204f,0f,0.48736095278074687f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2896056282533592f);
moveline1 = Instantiate(moveline,new Vector3(8.315528808376204f,0f,0.48736095278074687f),Quaternion.Euler(0,-41.99197157556324f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.9584846538330613f);
}
}
public class frame195 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(5.863048028348297f,0f,-0.44249442609785544f);
skate0.transform.rotation = Quaternion.Euler(0,46.432394487827f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(5.863048028348297f,0f,-0.44249442609785544f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2988171443998093f);
moveline0 = Instantiate(moveline,new Vector3(5.863048028348297f,0f,-0.44249442609785544f),Quaternion.Euler(0,137.1485917317405f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
skate1.transform.position = new Vector3(8.363048028348297f,0f,0.44249442609785544f);
skate1.transform.rotation = Quaternion.Euler(0,133.567605512173f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(8.363048028348297f,0f,0.44249442609785544f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2988171443998093f);
moveline1 = Instantiate(moveline,new Vector3(8.363048028348297f,0f,0.44249442609785544f),Quaternion.Euler(0,42.85140826825949f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
}
}
public class frame196 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(5.909400659377365f,0f,-0.3965182288188981f);
skate0.transform.rotation = Quaternion.Euler(0,45.85943669269617f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(5.909400659377365f,0f,-0.3965182288188981f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3082145437166002f);
moveline0 = Instantiate(moveline,new Vector3(5.909400659377365f,0f,-0.3965182288188981f),Quaternion.Euler(0,-136.432394487827f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.9478820883354085f);
skate1.transform.position = new Vector3(8.409400659377365f,0f,0.3965182288188981f);
skate1.transform.rotation = Quaternion.Euler(0,134.14056330730384f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(8.409400659377365f,0f,0.3965182288188981f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3082145437166002f);
moveline1 = Instantiate(moveline,new Vector3(8.409400659377365f,0f,0.3965182288188981f),Quaternion.Euler(0,-43.567605512173f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.9478820883354085f);
}
}
public class frame197 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(5.956996899387129f,0f,-0.34947027082868953f);
skate0.transform.rotation = Quaternion.Euler(0,45.42971834634806f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(5.956996899387129f,0f,-0.34947027082868953f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3178194354405959f);
moveline0 = Instantiate(moveline,new Vector3(5.956996899387129f,0f,-0.34947027082868953f),Quaternion.Euler(0,135.85943669269616f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(8.45699689938713f,0f,0.34947027082868953f);
skate1.transform.rotation = Quaternion.Euler(0,134.57028165365193f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(8.45699689938713f,0f,0.34947027082868953f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3178194354405959f);
moveline1 = Instantiate(moveline,new Vector3(8.45699689938713f,0f,0.34947027082868953f),Quaternion.Euler(0,44.140563307303836f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame198 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(6.003407893359533f,0f,-0.3012547134725214f);
skate0.transform.rotation = Quaternion.Euler(0,45.143239448782644f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(6.003407893359533f,0f,-0.3012547134725214f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3276249168467757f);
moveline0 = Instantiate(moveline,new Vector3(6.003407893359533f,0f,-0.3012547134725214f),Quaternion.Euler(0,-135.42971834634807f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.9457869070740352f);
skate1.transform.position = new Vector3(8.503407893359535f,0f,0.3012547134725214f);
skate1.transform.rotation = Quaternion.Euler(0,134.85676055121735f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(8.503407893359535f,0f,0.3012547134725214f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3276249168467757f);
moveline1 = Instantiate(moveline,new Vector3(8.503407893359535f,0f,0.3012547134725214f),Quaternion.Euler(0,-44.57028165365193f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.9457869070740352f);
}
}
public class frame199 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(6.051078417343308f,0f,-0.25191633481417475f);
skate0.transform.rotation = Quaternion.Euler(0,44.999999999999936f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(6.051078417343308f,0f,-0.25191633481417475f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3376522658105212f);
moveline0 = Instantiate(moveline,new Vector3(6.051078417343308f,0f,-0.25191633481417475f),Quaternion.Euler(0,135.14323944878265f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(8.551078417343309f,0f,0.25191633481417475f);
skate1.transform.rotation = Quaternion.Euler(0,135.00000000000006f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(8.551078417343309f,0f,0.25191633481417475f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3376522658105212f);
moveline1 = Instantiate(moveline,new Vector3(8.551078417343309f,0f,0.25191633481417475f),Quaternion.Euler(0,44.85676055121736f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame200 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(6.100011632007773f,0f,-0.20143369363349406f);
skate0.transform.rotation = Quaternion.Euler(0,44.999999999999936f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(6.100011632007773f,0f,-0.20143369363349406f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3478937936936064f);
moveline0 = Instantiate(moveline,new Vector3(6.100011632007773f,0f,-0.20143369363349406f),Quaternion.Euler(0,134.99999999999994f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(8.600011632007773f,0f,0.20143369363349406f);
skate1.transform.rotation = Quaternion.Euler(0,135.00000000000006f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(8.600011632007773f,0f,0.20143369363349406f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3478937936936064f);
moveline1 = Instantiate(moveline,new Vector3(8.600011632007773f,0f,0.20143369363349406f),Quaternion.Euler(0,45.000000000000064f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame201 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(6.1502075373529275f,0f,-0.1519309646120791f);
skate0.transform.rotation = Quaternion.Euler(0,45.14323944878264f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(6.1502075373529275f,0f,-0.1519309646120791f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.1583559719977304f);
moveline0 = Instantiate(moveline,new Vector3(6.1502075373529275f,0f,-0.1519309646120791f),Quaternion.Euler(0,134.99999999999994f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(8.650207537352928f,0f,0.1519309646120791f);
skate1.transform.rotation = Quaternion.Euler(0,134.85676055121735f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(8.650207537352928f,0f,0.1519309646120791f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.1583559719977304f);
moveline1 = Instantiate(moveline,new Vector3(8.650207537352928f,0f,0.1519309646120791f),Quaternion.Euler(0,45.000000000000064f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame202 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(6.200252907249944f,0f,-0.1022784509443263f);
skate0.transform.rotation = Quaternion.Euler(0,45.429718346348054f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(6.200252907249944f,0f,-0.1022784509443263f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.16860180943303377f);
moveline0 = Instantiate(moveline,new Vector3(6.200252907249944f,0f,-0.1022784509443263f),Quaternion.Euler(0,-135.14323944878262f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.11951715860618917f);
skate1.transform.position = new Vector3(8.700252907249945f,0f,0.1022784509443263f);
skate1.transform.rotation = Quaternion.Euler(0,134.57028165365193f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(8.700252907249945f,0f,0.1022784509443263f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.16860180943303377f);
moveline1 = Instantiate(moveline,new Vector3(8.700252907249945f,0f,0.1022784509443263f),Quaternion.Euler(0,-44.85676055121738f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.11951715860618917f);
}
}
public class frame203 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(6.250138590883241f,0f,-0.052468628520083195f);
skate0.transform.rotation = Quaternion.Euler(0,45.859436692696164f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(6.250138590883241f,0f,-0.052468628520083195f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.17886873772244405f);
moveline0 = Instantiate(moveline,new Vector3(6.250138590883241f,0f,-0.052468628520083195f),Quaternion.Euler(0,-135.42971834634807f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.1274243260095966f);
skate1.transform.position = new Vector3(8.750138590883243f,0f,0.052468628520083195f);
skate1.transform.rotation = Quaternion.Euler(0,134.14056330730384f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(8.750138590883243f,0f,0.052468628520083195f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.17886873772244405f);
moveline1 = Instantiate(moveline,new Vector3(8.750138590883243f,0f,0.052468628520083195f),Quaternion.Euler(0,-44.57028165365193f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.1274243260095966f);
}
}
public class frame204 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(6.301267883497235f,0f,-0.003602506001207803f);
skate0.transform.rotation = Quaternion.Euler(0,46.43239448782699f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(6.301267883497235f,0f,-0.003602506001207803f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.18916149013399086f);
moveline0 = Instantiate(moveline,new Vector3(6.301267883497235f,0f,-0.003602506001207803f),Quaternion.Euler(0,135.85943669269616f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(8.801267883497236f,0f,0.003602506001207803f);
skate1.transform.rotation = Quaternion.Euler(0,133.567605512173f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(8.801267883497236f,0f,0.003602506001207803f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.18916149013399086f);
moveline1 = Instantiate(moveline,new Vector3(8.801267883497236f,0f,0.003602506001207803f),Quaternion.Euler(0,44.14056330730384f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame205 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(6.352219491422476f,0f,0.04543263189849928f);
skate0.transform.rotation = Quaternion.Euler(0,47.14859173174052f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(6.352219491422476f,0f,0.04543263189849928f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.1992558693541207f);
moveline0 = Instantiate(moveline,new Vector3(6.352219491422476f,0f,0.04543263189849928f),Quaternion.Euler(0,-136.432394487827f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.14437316146929077f);
skate1.transform.position = new Vector3(8.852219491422478f,0f,-0.04543263189849928f);
skate1.transform.rotation = Quaternion.Euler(0,132.8514082682595f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(8.852219491422478f,0f,-0.04543263189849928f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.1992558693541207f);
moveline1 = Instantiate(moveline,new Vector3(8.852219491422478f,0f,-0.04543263189849928f),Quaternion.Euler(0,-43.567605512173f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.14437316146929077f);
}
}
public class frame206 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(6.4043855624996215f,0f,0.09353252871328713f);
skate0.transform.rotation = Quaternion.Euler(0,48.00802842443675f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(6.4043855624996215f,0f,0.09353252871328713f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.20938493736308303f);
moveline0 = Instantiate(moveline,new Vector3(6.4043855624996215f,0f,0.09353252871328713f),Quaternion.Euler(0,137.1485917317405f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(8.904385562499623f,0f,-0.09353252871328713f);
skate1.transform.rotation = Quaternion.Euler(0,131.99197157556324f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(8.904385562499623f,0f,-0.09353252871328713f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.20938493736308303f);
moveline1 = Instantiate(moveline,new Vector3(8.904385562499623f,0f,-0.09353252871328713f),Quaternion.Euler(0,42.8514082682595f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame207 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(6.457746323699131f,0f,0.14069686307161539f);
skate0.transform.rotation = Quaternion.Euler(0,49.01070456591569f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(6.457746323699131f,0f,0.14069686307161539f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.21932360277750887f);
moveline0 = Instantiate(moveline,new Vector3(6.457746323699131f,0f,0.14069686307161539f),Quaternion.Euler(0,138.00802842443676f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(8.957746323699133f,0f,-0.14069686307161539f);
skate1.transform.rotation = Quaternion.Euler(0,130.9892954340843f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(8.957746323699133f,0f,-0.14069686307161539f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.21932360277750887f);
moveline1 = Instantiate(moveline,new Vector3(8.957746323699133f,0f,-0.14069686307161539f),Quaternion.Euler(0,41.99197157556325f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame208 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(6.51090455522522f,0f,0.18803718736814917f);
skate0.transform.rotation = Quaternion.Euler(0,50.15662015617734f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(6.51090455522522f,0f,0.18803718736814917f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.22907450000669677f);
moveline0 = Instantiate(moveline,new Vector3(6.51090455522522f,0f,0.18803718736814917f),Quaternion.Euler(0,-139.0107045659157f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.172912794717335f);
skate1.transform.position = new Vector3(9.010904555225222f,0f,-0.18803718736814917f);
skate1.transform.rotation = Quaternion.Euler(0,129.84337984382267f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(9.010904555225222f,0f,-0.18803718736814917f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.22907450000669677f);
moveline1 = Instantiate(moveline,new Vector3(9.010904555225222f,0f,-0.18803718736814917f),Quaternion.Euler(0,-40.98929543408428f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.172912794717335f);
}
}
public class frame209 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(6.565206878179224f,0f,0.23443299641910537f);
skate0.transform.rotation = Quaternion.Euler(0,51.445775195221685f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(6.565206878179224f,0f,0.23443299641910537f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.23887012535172988f);
moveline0 = Instantiate(moveline,new Vector3(6.565206878179224f,0f,0.23443299641910537f),Quaternion.Euler(0,140.15662015617733f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(9.065206878179227f,0f,-0.23443299641910537f);
skate1.transform.rotation = Quaternion.Euler(0,128.5542248047783f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(9.065206878179227f,0f,-0.23443299641910537f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.23887012535172988f);
moveline1 = Instantiate(moveline,new Vector3(9.065206878179227f,0f,-0.23443299641910537f),Quaternion.Euler(0,39.84337984382266f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame210 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(6.6206221565246235f,0f,0.2798760599148735f);
skate0.transform.rotation = Quaternion.Euler(0,52.878169683048746f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(6.6206221565246235f,0f,0.2798760599148735f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.2484811468426249f);
moveline0 = Instantiate(moveline,new Vector3(6.6206221565246235f,0f,0.2798760599148735f),Quaternion.Euler(0,141.4457751952217f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(9.120622156524627f,0f,-0.2798760599148735f);
skate1.transform.rotation = Quaternion.Euler(0,127.12183031695125f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(9.120622156524627f,0f,-0.2798760599148735f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.2484811468426249f);
moveline1 = Instantiate(moveline,new Vector3(9.120622156524627f,0f,-0.2798760599148735f),Quaternion.Euler(0,38.554224804778315f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame211 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(6.677115134570257f,0f,0.3243558265467492f);
skate0.transform.rotation = Quaternion.Euler(0,54.45380361965851f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(6.677115134570257f,0f,0.3243558265467492f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.25790779833580835f);
moveline0 = Instantiate(moveline,new Vector3(6.677115134570257f,0f,0.3243558265467492f),Quaternion.Euler(0,142.87816968304875f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(9.17711513457026f,0f,-0.3243558265467492f);
skate1.transform.rotation = Quaternion.Euler(0,125.54619638034148f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(9.17711513457026f,0f,-0.3243558265467492f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.25790779833580835f);
moveline1 = Instantiate(moveline,new Vector3(9.17711513457026f,0f,-0.3243558265467492f),Quaternion.Euler(0,37.121830316951254f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame212 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(6.734646253992825f,0f,0.3678597047621666f);
skate0.transform.rotation = Quaternion.Euler(0,56.17267700505098f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(6.734646253992825f,0f,0.3678597047621666f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.2671495320046923f);
moveline0 = Instantiate(moveline,new Vector3(6.734646253992825f,0f,0.3678597047621666f),Quaternion.Euler(0,144.45380361965852f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(9.234646253992826f,0f,-0.3678597047621666f);
skate1.transform.rotation = Quaternion.Euler(0,123.82732299494901f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(9.234646253992826f,0f,-0.3678597047621666f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.2671495320046923f);
moveline1 = Instantiate(moveline,new Vector3(9.234646253992826f,0f,-0.3678597047621666f),Quaternion.Euler(0,35.54619638034149f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame213 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(6.793171465967118f,0f,0.410373379395098f);
skate0.transform.rotation = Quaternion.Euler(0,58.03478983922615f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(6.793171465967118f,0f,0.410373379395098f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.2762050844525475f);
moveline0 = Instantiate(moveline,new Vector3(6.793171465967118f,0f,0.410373379395098f),Quaternion.Euler(0,146.17267700505099f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
skate1.transform.position = new Vector3(9.29317146596712f,0f,-0.410373379395098f);
skate1.transform.rotation = Quaternion.Euler(0,121.96521016077385f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(9.29317146596712f,0f,-0.410373379395098f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.2762050844525475f);
moveline1 = Instantiate(moveline,new Vector3(9.29317146596712f,0f,-0.410373379395098f),Quaternion.Euler(0,33.82732299494902f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
}
}
public class frame214 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(6.8526420426451855f,0f,0.45188116624921537f);
skate0.transform.rotation = Quaternion.Euler(0,60.04014212218404f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(6.8526420426451855f,0f,0.45188116624921537f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.2850725491830715f);
moveline0 = Instantiate(moveline,new Vector3(6.8526420426451855f,0f,0.45188116624921537f),Quaternion.Euler(0,148.03478983922616f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(9.352642042645188f,0f,-0.45188116624921537f);
skate1.transform.rotation = Quaternion.Euler(0,119.95985787781596f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(9.352642042645188f,0f,-0.45188116624921537f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.2850725491830715f);
moveline1 = Instantiate(moveline,new Vector3(9.352642042645188f,0f,-0.45188116624921537f),Quaternion.Euler(0,31.965210160773843f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame215 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(6.913004392768559f,0f,0.4923664066019939f);
skate0.transform.rotation = Quaternion.Euler(0,62.188733853924624f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(6.913004392768559f,0f,0.4923664066019939f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.2937494565589485f);
moveline0 = Instantiate(moveline,new Vector3(6.913004392768559f,0f,0.4923664066019939f),Quaternion.Euler(0,150.04014212218405f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(9.413004392768562f,0f,-0.4923664066019939f);
skate1.transform.rotation = Quaternion.Euler(0,117.81126614607538f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(9.413004392768562f,0f,-0.4923664066019939f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.2937494565589485f);
moveline1 = Instantiate(moveline,new Vector3(9.413004392768562f,0f,-0.4923664066019939f),Quaternion.Euler(0,29.959857877815956f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame216 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(6.974199886762768f,0f,0.5318119034020208f);
skate0.transform.rotation = Quaternion.Euler(0,64.48056503444792f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(6.974199886762768f,0f,0.5318119034020208f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.3022328623426455f);
moveline0 = Instantiate(moveline,new Vector3(6.974199886762768f,0f,0.5318119034020208f),Quaternion.Euler(0,152.18873385392465f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(9.47419988676277f,0f,-0.5318119034020208f);
skate1.transform.rotation = Quaternion.Euler(0,115.51943496555208f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(9.47419988676277f,0f,-0.5318119034020208f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.3022328623426455f);
moveline1 = Instantiate(moveline,new Vector3(9.47419988676277f,0f,-0.5318119034020208f),Quaternion.Euler(0,27.81126614607536f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame217 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(7.036164697243939f,0f,0.5702004006387846f);
skate0.transform.rotation = Quaternion.Euler(0,66.91563566375392f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(7.036164697243939f,0f,0.5702004006387846f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.3105194458540015f);
moveline0 = Instantiate(moveline,new Vector3(7.036164697243939f,0f,0.5702004006387846f),Quaternion.Euler(0,154.48056503444792f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(9.536164697243942f,0f,-0.5702004006387846f);
skate1.transform.rotation = Quaternion.Euler(0,113.08436433624608f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(9.536164697243942f,0f,-0.5702004006387846f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.3105194458540015f);
moveline1 = Instantiate(moveline,new Vector3(9.536164697243942f,0f,-0.5702004006387846f),Quaternion.Euler(0,25.51943496555208f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame218 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(7.0988296614544f,0f,0.6075151069634918f);
skate0.transform.rotation = Quaternion.Euler(0,69.49394574184262f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(7.0988296614544f,0f,0.6075151069634918f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.3186056186904421f);
moveline0 = Instantiate(moveline,new Vector3(7.0988296614544f,0f,0.6075151069634918f),Quaternion.Euler(0,156.9156356637539f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(9.598829661454403f,0f,-0.6075151069634918f);
skate1.transform.rotation = Quaternion.Euler(0,110.50605425815738f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(9.598829661454403f,0f,-0.6075151069634918f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.3186056186904421f);
moveline1 = Instantiate(moveline,new Vector3(9.598829661454403f,0f,-0.6075151069634918f),Quaternion.Euler(0,23.084364336246082f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame219 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(7.162120172726288f,0f,0.6437402641204939f);
skate0.transform.rotation = Quaternion.Euler(0,72.21549526871404f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(7.162120172726288f,0f,0.6437402641204939f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.3264876448326808f);
moveline0 = Instantiate(moveline,new Vector3(7.162120172726288f,0f,0.6437402641204939f),Quaternion.Euler(0,159.49394574184262f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
skate1.transform.position = new Vector3(9.662120172726292f,0f,-0.6437402641204939f);
skate1.transform.rotation = Quaternion.Euler(0,107.78450473128596f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(9.662120172726292f,0f,-0.6437402641204939f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.3264876448326808f);
moveline1 = Instantiate(moveline,new Vector3(9.662120172726292f,0f,-0.6437402641204939f),Quaternion.Euler(0,20.506054258157377f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
}
}
public class frame220 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(7.2259561086350015f,0f,0.6788617601017454f);
skate0.transform.rotation = Quaternion.Euler(0,75.08028424436816f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(7.2259561086350015f,0f,0.6788617601017454f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.33416177279672954f);
moveline0 = Instantiate(moveline,new Vector3(7.2259561086350015f,0f,0.6788617601017454f),Quaternion.Euler(0,162.21549526871405f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(9.725956108635005f,0f,-0.6788617601017454f);
skate1.transform.rotation = Quaternion.Euler(0,104.91971575563184f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(9.725956108635005f,0f,-0.6788617601017454f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.33416177279672954f);
moveline1 = Instantiate(moveline,new Vector3(9.725956108635005f,0f,-0.6788617601017454f),Quaternion.Euler(0,17.784504731285963f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame221 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(7.290251804030539f,0f,0.7128677861523173f);
skate0.transform.rotation = Quaternion.Euler(0,78.08831266880497f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(7.290251804030539f,0f,0.7128677861523173f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.34162438028782277f);
moveline0 = Instantiate(moveline,new Vector3(7.290251804030539f,0f,0.7128677861523173f),Quaternion.Euler(0,165.08028424436816f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(9.790251804030541f,0f,-0.7128677861523173f);
skate1.transform.rotation = Quaternion.Euler(0,101.91168733119503f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(9.790251804030541f,0f,-0.7128677861523173f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.34162438028782277f);
moveline1 = Instantiate(moveline,new Vector3(9.790251804030541f,0f,-0.7128677861523173f),Quaternion.Euler(0,14.919715755631856f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame222 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(7.354916077604158f,0f,0.7457495358258218f);
skate0.transform.rotation = Quaternion.Euler(0,81.2395805420245f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(7.354916077604158f,0f,0.7457495358258218f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.34887213156035773f);
moveline0 = Instantiate(moveline,new Vector3(7.354916077604158f,0f,0.7457495358258218f),Quaternion.Euler(0,168.08831266880497f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(9.85491607760416f,0f,-0.7457495358258218f);
skate1.transform.rotation = Quaternion.Euler(0,98.7604194579755f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(9.85491607760416f,0f,-0.7457495358258218f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.34887213156035773f);
moveline1 = Instantiate(moveline,new Vector3(9.85491607760416f,0f,-0.7457495358258218f),Quaternion.Euler(0,11.911687331195026f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame223 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(7.419852321036737f,0f,0.777501943209124f);
skate0.transform.rotation = Quaternion.Euler(0,84.53408786402673f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(7.419852321036737f,0f,0.777501943209124f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.35590214738849846f);
moveline0 = Instantiate(moveline,new Vector3(7.419852321036737f,0f,0.777501943209124f),Quaternion.Euler(0,171.2395805420245f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(9.919852321036739f,0f,-0.777501943209124f);
skate1.transform.rotation = Quaternion.Euler(0,95.46591213597327f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(9.919852321036739f,0f,-0.777501943209124f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.35590214738849846f);
moveline1 = Instantiate(moveline,new Vector3(9.919852321036739f,0f,-0.777501943209124f),Quaternion.Euler(0,8.760419457975487f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame224 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(7.484958660057068f,0f,0.8081244562031595f);
skate0.transform.rotation = Quaternion.Euler(0,87.97183463481169f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(7.484958660057068f,0f,0.8081244562031595f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.3627121872047431f);
moveline0 = Instantiate(moveline,new Vector3(7.484958660057068f,0f,0.8081244562031595f),Quaternion.Euler(0,174.53408786402673f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(9.98495866005707f,0f,-0.8081244562031595f);
skate1.transform.rotation = Quaternion.Euler(0,92.02816536518831f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(9.98495866005707f,0f,-0.8081244562031595f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.3627121872047431f);
moveline1 = Instantiate(moveline,new Vector3(9.98495866005707f,0f,-0.8081244562031595f),Quaternion.Euler(0,5.465912135973269f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame225 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(7.550128196883413f,0f,0.8376218393617294f);
skate0.transform.rotation = Quaternion.Euler(0,91.55282085437932f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(7.550128196883413f,0f,0.8376218393617294f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.36930084257074125f);
moveline0 = Instantiate(moveline,new Vector3(7.550128196883413f,0f,0.8376218393617294f),Quaternion.Euler(0,177.97183463481167f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(10.050128196883414f,0f,-0.8376218393617294f);
skate1.transform.rotation = Quaternion.Euler(0,88.44717914562068f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(10.050128196883414f,0f,-0.8376218393617294f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.36930084257074125f);
moveline1 = Instantiate(moveline,new Vector3(10.050128196883414f,0f,-0.8376218393617294f),Quaternion.Euler(0,2.0281653651883147f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame226 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(7.61524934349732f,0f,0.8631478564006662f);
skate0.transform.rotation = Quaternion.Euler(0,94.99056762516426f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(7.61524934349732f,0f,0.8631478564006662f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2243322592893917f);
moveline0 = Instantiate(moveline,new Vector3(7.61524934349732f,0f,0.8631478564006662f),Quaternion.Euler(0,-178.44717914562068f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(10.11524934349732f,0f,-0.8631478564006662f);
skate1.transform.rotation = Quaternion.Euler(0,85.00943237483574f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(10.11524934349732f,0f,-0.8631478564006662f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2243322592893917f);
moveline1 = Instantiate(moveline,new Vector3(10.11524934349732f,0f,-0.8631478564006662f),Quaternion.Euler(0,-1.5528208543793056f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame227 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(7.680215147714759f,0f,0.8847184897831071f);
skate0.transform.rotation = Quaternion.Euler(0,98.2850749471665f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(7.680215147714759f,0f,0.8847184897831071f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2188058149442325f);
moveline0 = Instantiate(moveline,new Vector3(7.680215147714759f,0f,0.8847184897831071f),Quaternion.Euler(0,-175.00943237483574f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(10.18021514771476f,0f,-0.8847184897831071f);
skate1.transform.rotation = Quaternion.Euler(0,81.7149250528335f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(10.18021514771476f,0f,-0.8847184897831071f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2188058149442325f);
moveline1 = Instantiate(moveline,new Vector3(10.18021514771476f,0f,-0.8847184897831071f),Quaternion.Euler(0,-4.99056762516426f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame228 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(7.744923633301423f,0f,0.9023539686395695f);
skate0.transform.rotation = Quaternion.Euler(0,101.43634282038603f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(7.744923633301423f,0f,0.9023539686395695f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2141231755155428f);
moveline0 = Instantiate(moveline,new Vector3(7.744923633301423f,0f,0.9023539686395695f),Quaternion.Euler(0,-171.7149250528335f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(10.244923633301424f,0f,-0.9023539686395695f);
skate1.transform.rotation = Quaternion.Euler(0,78.56365717961397f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(10.244923633301424f,0f,-0.9023539686395695f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2141231755155428f);
moveline1 = Instantiate(moveline,new Vector3(10.244923633301424f,0f,-0.9023539686395695f),Quaternion.Euler(0,-8.285074947166493f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame229 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(7.809278049087339f,0f,0.9160779624783352f);
skate0.transform.rotation = Quaternion.Euler(0,104.44437124482285f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(7.809278049087339f,0f,0.9160779624783352f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2102860069023396f);
moveline0 = Instantiate(moveline,new Vector3(7.809278049087339f,0f,0.9160779624783352f),Quaternion.Euler(0,-168.56365717961398f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(10.30927804908734f,0f,-0.9160779624783352f);
skate1.transform.rotation = Quaternion.Euler(0,75.55562875517715f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(10.30927804908734f,0f,-0.9160779624783352f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2102860069023396f);
moveline1 = Instantiate(moveline,new Vector3(10.30927804908734f,0f,-0.9160779624783352f),Quaternion.Euler(0,-11.436342820386031f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame230 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(7.873187036468134f,0f,0.9259168052660687f);
skate0.transform.rotation = Quaternion.Euler(0,107.30916022047697f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(7.873187036468134f,0f,0.9259168052660687f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2072943093713122f);
moveline0 = Instantiate(moveline,new Vector3(7.873187036468134f,0f,0.9259168052660687f),Quaternion.Euler(0,-165.55562875517717f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(10.373187036468135f,0f,-0.9259168052660687f);
skate1.transform.rotation = Quaternion.Euler(0,72.69083977952303f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(10.373187036468135f,0f,-0.9259168052660687f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2072943093713122f);
moveline1 = Instantiate(moveline,new Vector3(10.373187036468135f,0f,-0.9259168052660687f),Quaternion.Euler(0,-14.444371244822833f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame231 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(7.936564724717463f,0f,0.9318987557129206f);
skate0.transform.rotation = Quaternion.Euler(0,110.03070974734838f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(7.936564724717463f,0f,0.9318987557129206f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2051464667003526f);
moveline0 = Instantiate(moveline,new Vector3(7.936564724717463f,0f,0.9318987557129206f),Quaternion.Euler(0,-162.690839779523f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(10.436564724717464f,0f,-0.9318987557129206f);
skate1.transform.rotation = Quaternion.Euler(0,69.96929025265162f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(10.436564724717464f,0f,-0.9318987557129206f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2051464667003526f);
moveline1 = Instantiate(moveline,new Vector3(10.436564724717464f,0f,-0.9318987557129206f),Quaternion.Euler(0,-17.30916022047697f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame232 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(7.999330763401694f,0f,0.9340532981400238f);
skate0.transform.rotation = Quaternion.Euler(0,112.60901982543709f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(7.999330763401694f,0f,0.9340532981400238f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2038393233208047f);
moveline0 = Instantiate(moveline,new Vector3(7.999330763401694f,0f,0.9340532981400238f),Quaternion.Euler(0,-159.96929025265163f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(10.499330763401696f,0f,-0.9340532981400238f);
skate1.transform.rotation = Quaternion.Euler(0,67.39098017456291f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(10.499330763401696f,0f,-0.9340532981400238f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2038393233208047f);
moveline1 = Instantiate(moveline,new Vector3(10.499330763401696f,0f,-0.9340532981400238f),Quaternion.Euler(0,-20.030709747348354f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame233 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(8.06141030091652f,0f,0.9324104870043327f);
skate0.transform.rotation = Quaternion.Euler(0,115.04409045474308f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(8.06141030091652f,0f,0.9324104870043327f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2033682874331124f);
moveline0 = Instantiate(moveline,new Vector3(8.06141030091652f,0f,0.9324104870043327f),Quaternion.Euler(0,-157.3909801745629f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(10.561410300916522f,0f,-0.9324104870043327f);
skate1.transform.rotation = Quaternion.Euler(0,64.95590954525692f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(10.561410300916522f,0f,-0.9324104870043327f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2033682874331124f);
moveline1 = Instantiate(moveline,new Vector3(10.561410300916522f,0f,-0.9324104870043327f),Quaternion.Euler(0,-22.609019825437073f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame234 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(8.122733917785316f,0f,0.9270003370084877f);
skate0.transform.rotation = Quaternion.Euler(0,117.33592163526637f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(8.122733917785316f,0f,0.9270003370084877f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2037274576878656f);
moveline0 = Instantiate(moveline,new Vector3(8.122733917785316f,0f,0.9270003370084877f),Quaternion.Euler(0,-154.9559095452569f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(10.622733917785318f,0f,-0.9270003370084877f);
skate1.transform.rotation = Quaternion.Euler(0,62.66407836473362f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(10.622733917785318f,0f,-0.9270003370084877f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2037274576878656f);
moveline1 = Instantiate(moveline,new Vector3(10.622733917785318f,0f,-0.9270003370084877f),Quaternion.Euler(0,-25.0440904547431f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame235 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(8.183237522897684f,0f,0.9178522597303805f);
skate0.transform.rotation = Quaternion.Euler(0,119.48451336700697f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(8.183237522897684f,0f,0.9178522597303805f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.204909770745073f);
moveline0 = Instantiate(moveline,new Vector3(8.183237522897684f,0f,0.9178522597303805f),Quaternion.Euler(0,-152.6640783647336f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(10.683237522897686f,0f,-0.9178522597303805f);
skate1.transform.rotation = Quaternion.Euler(0,60.51548663299303f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(10.683237522897686f,0f,-0.9178522597303805f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.204909770745073f);
moveline1 = Instantiate(moveline,new Vector3(10.683237522897686f,0f,-0.9178522597303805f),Quaternion.Euler(0,-27.335921635266388f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame236 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(8.242862220347023f,0f,0.9049945468638555f);
skate0.transform.rotation = Quaternion.Euler(0,121.48986564996486f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(8.242862220347023f,0f,0.9049945468638555f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.206907166857799f);
moveline0 = Instantiate(moveline,new Vector3(8.242862220347023f,0f,0.9049945468638555f),Quaternion.Euler(0,-150.51548663299303f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(10.742862220347025f,0f,-0.9049945468638555f);
skate1.transform.rotation = Quaternion.Euler(0,58.51013435003515f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(10.742862220347025f,0f,-0.9049945468638555f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.206907166857799f);
moveline1 = Instantiate(moveline,new Vector3(10.742862220347025f,0f,-0.9049945468638555f),Quaternion.Euler(0,-29.484513367006954f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame237 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(8.301554153968777f,0f,0.8884538994616612f);
skate0.transform.rotation = Quaternion.Euler(0,123.35197848414002f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(8.301554153968777f,0f,0.8884538994616612f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2097107705749892f);
moveline0 = Instantiate(moveline,new Vector3(8.301554153968777f,0f,0.8884538994616612f),Quaternion.Euler(0,-148.51013435003514f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(10.801554153968778f,0f,-0.8884538994616612f);
skate1.transform.rotation = Quaternion.Euler(0,56.64802151585998f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(10.801554153968778f,0f,-0.8884538994616612f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2097107705749892f);
moveline1 = Instantiate(moveline,new Vector3(10.801554153968778f,0f,-0.8884538994616612f),Quaternion.Euler(0,-31.48986564996484f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame238 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(8.35926433610338f,0f,0.8682550020057407f);
skate0.transform.rotation = Quaternion.Euler(0,125.0708518695325f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(8.35926433610338f,0f,0.8682550020057407f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.213311083719806f);
moveline0 = Instantiate(moveline,new Vector3(8.35926433610338f,0f,0.8682550020057407f),Quaternion.Euler(0,-146.64802151586f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(10.859264336103381f,0f,-0.8682550020057407f);
skate1.transform.rotation = Quaternion.Euler(0,54.9291481304675f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(10.859264336103381f,0f,-0.8682550020057407f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.213311083719806f);
moveline1 = Instantiate(moveline,new Vector3(10.859264336103381f,0f,-0.8682550020057407f),Quaternion.Euler(0,-33.351978484140005f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame239 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(8.415948466524313f,0f,0.844420139688361f);
skate0.transform.rotation = Quaternion.Euler(0,126.64648580614227f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(8.415948466524313f,0f,0.844420139688361f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.217698187967019f);
moveline0 = Instantiate(moveline,new Vector3(8.415948466524313f,0f,0.844420139688361f),Quaternion.Euler(0,-144.9291481304675f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(10.915948466524314f,0f,-0.844420139688361f);
skate1.transform.rotation = Quaternion.Euler(0,53.35351419385774f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(10.915948466524314f,0f,-0.844420139688361f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.217698187967019f);
moveline1 = Instantiate(moveline,new Vector3(10.915948466524314f,0f,-0.844420139688361f),Quaternion.Euler(0,-35.07085186953249f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame240 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(8.471566746893709f,0f,0.8169688569597856f);
skate0.transform.rotation = Quaternion.Euler(0,128.07888029396932f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(8.471566746893709f,0f,0.8169688569597856f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2228619546055488f);
moveline0 = Instantiate(moveline,new Vector3(8.471566746893709f,0f,0.8169688569597856f),Quaternion.Euler(0,-143.35351419385776f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
skate1.transform.position = new Vector3(10.97156674689371f,0f,-0.8169688569597856f);
skate1.transform.rotation = Quaternion.Euler(0,51.92111970603069f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(10.97156674689371f,0f,-0.8169688569597856f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2228619546055488f);
moveline1 = Instantiate(moveline,new Vector3(10.97156674689371f,0f,-0.8169688569597856f),Quaternion.Euler(0,-36.64648580614225f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
}
}
public class frame241 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(8.5260836955446f,0f,0.785917655173132f);
skate0.transform.rotation = Quaternion.Euler(0,129.36803533301367f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(8.5260836955446f,0f,0.785917655173132f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2287922594176688f);
moveline0 = Instantiate(moveline,new Vector3(8.5260836955446f,0f,0.785917655173132f),Quaternion.Euler(0,-141.92111970603068f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(11.026083695544601f,0f,-0.785917655173132f);
skate1.transform.rotation = Quaternion.Euler(0,50.631964666986335f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(11.026083695544601f,0f,-0.785917655173132f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2287922594176688f);
moveline1 = Instantiate(moveline,new Vector3(11.026083695544601f,0f,-0.785917655173132f),Quaternion.Euler(0,-38.07888029396932f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame242 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(8.57946796684704f,0f,0.7512797270235892f);
skate0.transform.rotation = Quaternion.Euler(0,130.5139509232753f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(8.57946796684704f,0f,0.7512797270235892f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2354792010214322f);
moveline0 = Instantiate(moveline,new Vector3(8.57946796684704f,0f,0.7512797270235892f),Quaternion.Euler(0,-140.63196466698633f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(11.079467966847043f,0f,-0.7512797270235892f);
skate1.transform.rotation = Quaternion.Euler(0,49.48604907672469f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(11.079467966847043f,0f,-0.7512797270235892f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2354792010214322f);
moveline1 = Instantiate(moveline,new Vector3(11.079467966847043f,0f,-0.7512797270235892f),Quaternion.Euler(0,-39.368035333013665f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame243 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(8.631692178899518f,0f,0.7130647254262864f);
skate0.transform.rotation = Quaternion.Euler(0,131.51662706475426f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(8.631692178899518f,0f,0.7130647254262864f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.24291332149491f);
moveline0 = Instantiate(moveline,new Vector3(8.631692178899518f,0f,0.7130647254262864f),Quaternion.Euler(0,-139.4860490767247f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(11.13169217889952f,0f,-0.7130647254262864f);
skate1.transform.rotation = Quaternion.Euler(0,48.48337293524575f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(11.13169217889952f,0f,-0.7130647254262864f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.24291332149491f);
moveline1 = Instantiate(moveline,new Vector3(11.13169217889952f,0f,-0.7130647254262864f),Quaternion.Euler(0,-40.5139509232753f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame244 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(8.68273275280015f,0f,0.6712785644941489f);
skate0.transform.rotation = Quaternion.Euler(0,132.37606375745048f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(8.68273275280015f,0f,0.6712785644941489f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2510858286187292f);
moveline0 = Instantiate(moveline,new Vector3(8.68273275280015f,0f,0.6712785644941489f),Quaternion.Euler(0,-138.48337293524577f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(11.182732752800153f,0f,-0.6712785644941489f);
skate1.transform.rotation = Quaternion.Euler(0,47.62393624254951f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(11.182732752800153f,0f,-0.6712785644941489f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2510858286187292f);
moveline1 = Instantiate(moveline,new Vector3(11.182732752800153f,0f,-0.6712785644941489f),Quaternion.Euler(0,-41.51662706475423f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame245 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(8.732569766295361f,0f,0.6259232503538315f);
skate0.transform.rotation = Quaternion.Euler(0,133.09226100136402f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(8.732569766295361f,0f,0.6259232503538315f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2599888196287645f);
moveline0 = Instantiate(moveline,new Vector3(8.732569766295361f,0f,0.6259232503538315f),Quaternion.Euler(0,-137.62393624254952f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(11.232569766295363f,0f,-0.6259232503538315f);
skate1.transform.rotation = Quaternion.Euler(0,46.907738998635985f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(11.232569766295363f,0f,-0.6259232503538315f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2599888196287645f);
moveline1 = Instantiate(moveline,new Vector3(11.232569766295363f,0f,-0.6259232503538315f),Quaternion.Euler(0,-42.37606375745048f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame246 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(8.781186824176832f,0f,0.5769967396645939f);
skate0.transform.rotation = Quaternion.Euler(0,133.66521879649483f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(8.781186824176832f,0f,0.5769967396645939f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.269615506958729f);
moveline0 = Instantiate(moveline,new Vector3(8.781186824176832f,0f,0.5769967396645939f),Quaternion.Euler(0,-136.907738998636f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(11.281186824176833f,0f,-0.5769967396645939f);
skate1.transform.rotation = Quaternion.Euler(0,46.334781203505166f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(11.281186824176833f,0f,-0.5769967396645939f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.269615506958729f);
moveline1 = Instantiate(moveline,new Vector3(11.281186824176833f,0f,-0.5769967396645939f),Quaternion.Euler(0,-43.092261001363994f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame247 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(8.83103681671744f,0f,0.5270763467670807f);
skate0.transform.rotation = Quaternion.Euler(0,134.09493714284295f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(8.83103681671744f,0f,0.5270763467670807f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2799604470720904f);
moveline0 = Instantiate(moveline,new Vector3(8.83103681671744f,0f,0.5270763467670807f),Quaternion.Euler(0,43.665218796494834f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(11.331036816717441f,0f,-0.5270763467670807f);
skate1.transform.rotation = Quaternion.Euler(0,45.90506285715705f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(11.331036816717441f,0f,-0.5270763467670807f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2799604470720904f);
moveline1 = Instantiate(moveline,new Vector3(11.331036816717441f,0f,-0.5270763467670807f),Quaternion.Euler(0,136.33478120350517f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame248 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(8.882129397361089f,0f,0.47613400966821445f);
skate0.transform.rotation = Quaternion.Euler(0,134.38141604040837f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(8.882129397361089f,0f,0.47613400966821445f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.290476541026408f);
moveline0 = Instantiate(moveline,new Vector3(8.882129397361089f,0f,0.47613400966821445f),Quaternion.Euler(0,44.094937142842966f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(11.38212939736109f,0f,-0.47613400966821445f);
skate1.transform.rotation = Quaternion.Euler(0,45.61858395959164f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(11.38212939736109f,0f,-0.47613400966821445f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.290476541026408f);
moveline1 = Instantiate(moveline,new Vector3(11.38212939736109f,0f,-0.47613400966821445f),Quaternion.Euler(0,135.90506285715702f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame249 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(8.932060488959443f,0f,0.42405499623261633f);
skate0.transform.rotation = Quaternion.Euler(0,134.52465548919108f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(8.932060488959443f,0f,0.42405499623261633f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.30117104968904f);
moveline0 = Instantiate(moveline,new Vector3(8.932060488959443f,0f,0.42405499623261633f),Quaternion.Euler(0,-44.38141604040834f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.9299464010922873f);
skate1.transform.position = new Vector3(11.432060488959445f,0f,-0.42405499623261633f);
skate1.transform.rotation = Quaternion.Euler(0,45.47534451080893f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(11.432060488959445f,0f,-0.42405499623261633f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.30117104968904f);
moveline1 = Instantiate(moveline,new Vector3(11.432060488959445f,0f,-0.42405499623261633f),Quaternion.Euler(0,-135.61858395959166f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.9299464010922873f);
}
}
public class frame250 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(8.98324375220949f,0f,0.3709061241561597f);
skate0.transform.rotation = Quaternion.Euler(0,134.52465548919108f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(8.98324375220949f,0f,0.3709061241561597f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.3120696071065587f);
moveline0 = Instantiate(moveline,new Vector3(8.98324375220949f,0f,0.3709061241561597f),Quaternion.Euler(0,44.52465548919107f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(11.483243752209491f,0f,-0.3709061241561597f);
skate1.transform.rotation = Quaternion.Euler(0,45.47534451080893f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(11.483243752209491f,0f,-0.3709061241561597f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.3120696071065587f);
moveline1 = Instantiate(moveline,new Vector3(11.483243752209491f,0f,-0.3709061241561597f),Quaternion.Euler(0,135.47534451080892f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame251 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(9.035679187111226f,0f,0.3188104461040865f);
skate0.transform.rotation = Quaternion.Euler(0,134.38141604040834f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(9.035679187111226f,0f,0.3188104461040865f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.12316011457109655f);
moveline0 = Instantiate(moveline,new Vector3(9.035679187111226f,0f,0.3188104461040865f),Quaternion.Euler(0,44.52465548919107f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(11.535679187111228f,0f,-0.3188104461040865f);
skate1.transform.rotation = Quaternion.Euler(0,45.618583959591646f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(11.535679187111228f,0f,-0.3188104461040865f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.12316011457109655f);
moveline1 = Instantiate(moveline,new Vector3(11.535679187111228f,0f,-0.3188104461040865f),Quaternion.Euler(0,135.47534451080892f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame252 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(9.087995003885746f,0f,0.2665977053081146f);
skate0.transform.rotation = Quaternion.Euler(0,134.09493714284295f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(9.087995003885746f,0f,0.2665977053081146f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.13400354035347445f);
moveline0 = Instantiate(moveline,new Vector3(9.087995003885746f,0f,0.2665977053081146f),Quaternion.Euler(0,-44.38141604040834f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.09577227384141386f);
skate1.transform.position = new Vector3(11.587995003885748f,0f,-0.2665977053081146f);
skate1.transform.rotation = Quaternion.Euler(0,45.905062857157056f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(11.587995003885748f,0f,-0.2665977053081146f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.13400354035347445f);
moveline1 = Instantiate(moveline,new Vector3(11.587995003885748f,0f,-0.2665977053081146f),Quaternion.Euler(0,-135.61858395959166f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.09577227384141386f);
}
}
public class frame253 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(9.141553408763308f,0f,0.21540878533561444f);
skate0.transform.rotation = Quaternion.Euler(0,133.66521879649483f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(9.141553408763308f,0f,0.21540878533561444f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.1448481271244978f);
moveline0 = Instantiate(moveline,new Vector3(9.141553408763308f,0f,0.21540878533561444f),Quaternion.Euler(0,44.09493714284295f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(11.64155340876331f,0f,-0.21540878533561444f);
skate1.transform.rotation = Quaternion.Euler(0,46.334781203505166f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(11.64155340876331f,0f,-0.21540878533561444f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.1448481271244978f);
moveline1 = Instantiate(moveline,new Vector3(11.64155340876331f,0f,-0.21540878533561444f),Quaternion.Euler(0,135.90506285715705f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame254 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(9.194973159596683f,0f,0.1640875256210692f);
skate0.transform.rotation = Quaternion.Euler(0,133.09226100136402f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(9.194973159596683f,0f,0.1640875256210692f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.15546124245561344f);
moveline0 = Instantiate(moveline,new Vector3(9.194973159596683f,0f,0.1640875256210692f),Quaternion.Euler(0,-43.66521879649483f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.1124585501421668f);
skate1.transform.position = new Vector3(11.694973159596685f,0f,-0.1640875256210692f);
skate1.transform.rotation = Quaternion.Euler(0,46.90773899863599f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(11.694973159596685f,0f,-0.1640875256210692f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.15546124245561344f);
moveline1 = Instantiate(moveline,new Vector3(11.694973159596685f,0f,-0.1640875256210692f),Quaternion.Euler(0,-136.33478120350517f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.1124585501421668f);
}
}
public class frame255 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(9.249612866043798f,0f,0.11377370844072753f);
skate0.transform.rotation = Quaternion.Euler(0,132.37606375745048f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(9.249612866043798f,0f,0.11377370844072753f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.1660867412825507f);
moveline0 = Instantiate(moveline,new Vector3(9.249612866043798f,0f,0.11377370844072753f),Quaternion.Euler(0,43.09226100136401f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(11.7496128660438f,0f,-0.11377370844072753f);
skate1.transform.rotation = Quaternion.Euler(0,47.62393624254952f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(11.7496128660438f,0f,-0.11377370844072753f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.1660867412825507f);
moveline1 = Instantiate(moveline,new Vector3(11.7496128660438f,0f,-0.11377370844072753f),Quaternion.Euler(0,136.90773899863598f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame256 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(9.304095650426575f,0f,0.06331672189701466f);
skate0.transform.rotation = Quaternion.Euler(0,131.51662706475423f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(9.304095650426575f,0f,0.06331672189701466f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.176492511386375f);
moveline0 = Instantiate(moveline,new Vector3(9.304095650426575f,0f,0.06331672189701466f),Quaternion.Euler(0,-42.37606375745048f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.13038154431624185f);
skate1.transform.position = new Vector3(11.804095650426577f,0f,-0.06331672189701466f);
skate1.transform.rotation = Quaternion.Euler(0,48.483372935245754f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(11.804095650426577f,0f,-0.06331672189701466f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.176492511386375f);
moveline1 = Instantiate(moveline,new Vector3(11.804095650426577f,0f,-0.06331672189701466f),Quaternion.Euler(0,-137.62393624254952f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.13038154431624185f);
}
}
public class frame257 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(9.359762072961198f,0f,0.013863026716563864f);
skate0.transform.rotation = Quaternion.Euler(0,130.5139509232753f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(9.359762072961198f,0f,0.013863026716563864f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.18692023546191694f);
moveline0 = Instantiate(moveline,new Vector3(9.359762072961198f,0f,0.013863026716563864f),Quaternion.Euler(0,41.516627064754246f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(11.8597620729612f,0f,-0.013863026716563864f);
skate1.transform.rotation = Quaternion.Euler(0,49.4860490767247f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(11.8597620729612f,0f,-0.013863026716563864f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.18692023546191694f);
moveline1 = Instantiate(moveline,new Vector3(11.8597620729612f,0f,-0.013863026716563864f),Quaternion.Euler(0,138.48337293524577f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame258 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(9.416588554745784f,0f,-0.03458511247196466f);
skate0.transform.rotation = Quaternion.Euler(0,129.36803533301367f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(9.416588554745784f,0f,-0.03458511247196466f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.19713645377427855f);
moveline0 = Instantiate(moveline,new Vector3(9.416588554745784f,0f,-0.03458511247196466f),Quaternion.Euler(0,40.51395092327531f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(11.916588554745786f,0f,0.03458511247196466f);
skate1.transform.rotation = Quaternion.Euler(0,50.63196466698634f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(11.916588554745786f,0f,0.03458511247196466f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.19713645377427855f);
moveline1 = Instantiate(moveline,new Vector3(11.916588554745786f,0f,0.03458511247196466f),Quaternion.Euler(0,139.4860490767247f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame259 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(9.47454771387882f,0f,-0.08202263825016715f);
skate0.transform.rotation = Quaternion.Euler(0,128.0788802939693f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(9.47454771387882f,0f,-0.08202263825016715f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.20714405241388908f);
moveline0 = Instantiate(moveline,new Vector3(9.47454771387882f,0f,-0.08202263825016715f),Quaternion.Euler(0,39.368035333013665f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(11.974547713878822f,0f,0.08202263825016715f);
skate1.transform.rotation = Quaternion.Euler(0,51.921119706030694f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(11.974547713878822f,0f,0.08202263825016715f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.20714405241388908f);
moveline1 = Instantiate(moveline,new Vector3(11.974547713878822f,0f,0.08202263825016715f),Quaternion.Euler(0,140.63196466698633f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame260 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(9.533608204730362f,0f,-0.1284419185683514f);
skate0.transform.rotation = Quaternion.Euler(0,126.64648580614225f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(9.533608204730362f,0f,-0.1284419185683514f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.2169449554958908f);
moveline0 = Instantiate(moveline,new Vector3(9.533608204730362f,0f,-0.1284419185683514f),Quaternion.Euler(0,38.078880293969306f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(12.033608204730363f,0f,0.1284419185683514f);
skate1.transform.rotation = Quaternion.Euler(0,53.35351419385775f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(12.033608204730363f,0f,0.1284419185683514f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.2169449554958908f);
moveline1 = Instantiate(moveline,new Vector3(12.033608204730363f,0f,0.1284419185683514f),Quaternion.Euler(0,141.9211197060307f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame261 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(9.59373454563344f,0f,-0.17383299659230472f);
skate0.transform.rotation = Quaternion.Euler(0,125.07085186953249f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(9.59373454563344f,0f,-0.17383299659230472f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.22654019089479194f);
moveline0 = Instantiate(moveline,new Vector3(9.59373454563344f,0f,-0.17383299659230472f),Quaternion.Euler(0,36.64648580614225f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(12.093734545633442f,0f,0.17383299659230472f);
skate1.transform.rotation = Quaternion.Euler(0,54.92914813046751f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(12.093734545633442f,0f,0.17383299659230472f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.22654019089479194f);
moveline1 = Instantiate(moveline,new Vector3(12.093734545633442f,0f,0.17383299659230472f),Quaternion.Euler(0,143.35351419385773f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame262 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(9.654886938250188f,0f,-0.2181838743030461f);
skate0.transform.rotation = Quaternion.Euler(0,123.35197848414f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(9.654886938250188f,0f,-0.2181838743030461f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.2359299590514138f);
moveline0 = Instantiate(moveline,new Vector3(9.654886938250188f,0f,-0.2181838743030461f),Quaternion.Euler(0,35.07085186953249f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
skate1.transform.position = new Vector3(12.15488693825019f,0f,0.2181838743030461f);
skate1.transform.rotation = Quaternion.Euler(0,56.64802151585999f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(12.15488693825019f,0f,0.2181838743030461f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.2359299590514138f);
moveline1 = Instantiate(moveline,new Vector3(12.15488693825019f,0f,0.2181838743030461f),Quaternion.Euler(0,144.92914813046752f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
}
}
public class frame263 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(9.717021082354087f,0f,-0.26148083194185057f);
skate0.transform.rotation = Quaternion.Euler(0,121.48986564996484f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(9.717021082354087f,0f,-0.26148083194185057f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.24511370608221342f);
moveline0 = Instantiate(moveline,new Vector3(9.717021082354087f,0f,-0.26148083194185057f),Quaternion.Euler(0,33.35197848414002f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(12.217021082354089f,0f,0.26148083194185057f);
skate1.transform.rotation = Quaternion.Euler(0,58.51013435003516f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(12.217021082354089f,0f,0.26148083194185057f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.24511370608221342f);
moveline1 = Instantiate(moveline,new Vector3(12.217021082354089f,0f,0.26148083194185057f),Quaternion.Euler(0,146.64802151585997f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame264 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(9.78008799028557f,0f,-0.30370878535386114f);
skate0.transform.rotation = Quaternion.Euler(0,119.48451336700695f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(9.78008799028557f,0f,-0.30370878535386114f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.25409020239517377f);
moveline0 = Instantiate(moveline,new Vector3(9.78008799028557f,0f,-0.30370878535386114f),Quaternion.Euler(0,31.489865649964848f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(12.280087990285573f,0f,0.30370878535386114f);
skate1.transform.rotation = Quaternion.Euler(0,60.515486632993046f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(12.280087990285573f,0f,0.30370878535386114f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.25409020239517377f);
moveline1 = Instantiate(moveline,new Vector3(12.280087990285573f,0f,0.30370878535386114f),Quaternion.Euler(0,148.51013435003514f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame265 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(9.844033805880084f,0f,-0.3448516831682357f);
skate0.transform.rotation = Quaternion.Euler(0,117.33592163526637f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(9.844033805880084f,0f,-0.3448516831682357f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.26285762798005613f);
moveline0 = Instantiate(moveline,new Vector3(9.844033805880084f,0f,-0.3448516831682357f),Quaternion.Euler(0,29.48451336700696f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(12.344033805880086f,0f,0.3448516831682357f);
skate1.transform.rotation = Quaternion.Euler(0,62.664078364733626f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(12.344033805880086f,0f,0.3448516831682357f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.26285762798005613f);
moveline1 = Instantiate(moveline,new Vector3(12.344033805880086f,0f,0.3448516831682357f),Quaternion.Euler(0,150.51548663299303f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame266 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(9.908799633231025f,0f,-0.38489294555076514f);
skate0.transform.rotation = Quaternion.Euler(0,115.04409045474307f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(9.908799633231025f,0f,-0.38489294555076514f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.27141366548849577f);
moveline0 = Instantiate(moveline,new Vector3(9.908799633231025f,0f,-0.38489294555076514f),Quaternion.Euler(0,27.335921635266367f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(12.408799633231027f,0f,0.38489294555076514f);
skate1.transform.rotation = Quaternion.Euler(0,64.95590954525693f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(12.408799633231027f,0f,0.38489294555076514f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.27141366548849577f);
moveline1 = Instantiate(moveline,new Vector3(12.408799633231027f,0f,0.38489294555076514f),Quaternion.Euler(0,152.66407836473363f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame267 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(9.974321381227996f,0f,-0.42381594596570077f);
skate0.transform.rotation = Quaternion.Euler(0,112.60901982543707f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(9.974321381227996f,0f,-0.42381594596570077f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.2797556021457685f);
moveline0 = Instantiate(moveline,new Vector3(9.974321381227996f,0f,-0.42381594596570077f),Quaternion.Euler(0,25.04409045474307f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(12.474321381227998f,0f,0.42381594596570077f);
skate1.transform.rotation = Quaternion.Euler(0,67.39098017456293f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(12.474321381227998f,0f,0.42381594596570077f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.2797556021457685f);
moveline1 = Instantiate(moveline,new Vector3(12.474321381227998f,0f,0.42381594596570077f),Quaternion.Euler(0,154.95590954525693f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame268 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(10.040529630394374f,0f,-0.4616045369765364f);
skate0.transform.rotation = Quaternion.Euler(0,110.03070974734837f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(10.040529630394374f,0f,-0.4616045369765364f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.28788044143568864f);
moveline0 = Instantiate(moveline,new Vector3(10.040529630394374f,0f,-0.4616045369765364f),Quaternion.Euler(0,22.609019825437073f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
skate1.transform.position = new Vector3(12.540529630394376f,0f,0.4616045369765364f);
skate1.transform.rotation = Quaternion.Euler(0,69.96929025265163f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(12.540529630394376f,0f,0.4616045369765364f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.28788044143568864f);
moveline1 = Instantiate(moveline,new Vector3(12.540529630394376f,0f,0.4616045369765364f),Quaternion.Euler(0,157.3909801745629f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
}
}
public class frame269 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(10.107349529125848f,0f,-0.49824362059028177f);
skate0.transform.rotation = Quaternion.Euler(0,107.30916022047695f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(10.107349529125848f,0f,-0.49824362059028177f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.29578502536790335f);
moveline0 = Instantiate(moveline,new Vector3(10.107349529125848f,0f,-0.49824362059028177f),Quaternion.Euler(0,20.030709747348368f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
skate1.transform.position = new Vector3(12.60734952912585f,0f,0.49824362059028177f);
skate1.transform.rotation = Quaternion.Euler(0,72.69083977952305f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(12.60734952912585f,0f,0.49824362059028177f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.29578502536790335f);
moveline1 = Instantiate(moveline,new Vector3(12.60734952912585f,0f,0.49824362059028177f),Quaternion.Euler(0,159.96929025265163f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
}
}
public class frame270 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(10.174700726988789f,0f,-0.533719762996482f);
skate0.transform.rotation = Quaternion.Euler(0,104.44437124482283f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(10.174700726988789f,0f,-0.533719762996482f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.3034661679681495f);
moveline0 = Instantiate(moveline,new Vector3(10.174700726988789f,0f,-0.533719762996482f),Quaternion.Euler(0,17.309160220476954f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(12.67470072698879f,0f,0.533719762996482f);
skate1.transform.rotation = Quaternion.Euler(0,75.55562875517717f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(12.67470072698879f,0f,0.533719762996482f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.3034661679681495f);
moveline1 = Instantiate(moveline,new Vector3(12.67470072698879f,0f,0.533719762996482f),Quaternion.Euler(0,162.69083977952306f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame271 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(10.24249735325685f,0f,-0.568021852761997f);
skate0.transform.rotation = Quaternion.Euler(0,101.43634282038602f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(10.24249735325685f,0f,-0.568021852761997f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.3109208004228704f);
moveline0 = Instantiate(moveline,new Vector3(10.24249735325685f,0f,-0.568021852761997f),Quaternion.Euler(0,14.444371244822833f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(12.742497353256852f,0f,0.568021852761997f);
skate1.transform.rotation = Quaternion.Euler(0,78.56365717961398f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(12.742497353256852f,0f,0.568021852761997f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.3109208004228704f);
moveline1 = Instantiate(moveline,new Vector3(12.742497353256852f,0f,0.568021852761997f),Quaternion.Euler(0,165.55562875517717f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame272 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(10.310648049325659f,0f,-0.6011418006079569f);
skate0.transform.rotation = Quaternion.Euler(0,98.28507494716648f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(10.310648049325659f,0f,-0.6011418006079569f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.31814612805702785f);
moveline0 = Instantiate(moveline,new Vector3(10.310648049325659f,0f,-0.6011418006079569f),Quaternion.Euler(0,11.436342820386017f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(12.81064804932566f,0f,0.6011418006079569f);
skate1.transform.rotation = Quaternion.Euler(0,81.71492505283352f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(12.81064804932566f,0f,0.6011418006079569f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.31814612805702785f);
moveline1 = Instantiate(moveline,new Vector3(12.81064804932566f,0f,0.6011418006079569f),Quaternion.Euler(0,168.56365717961398f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame273 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(10.379056064025244f,0f,-0.6330752778110489f);
skate0.transform.rotation = Quaternion.Euler(0,94.99056762516425f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(10.379056064025244f,0f,-0.6330752778110489f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.3251397990263892f);
moveline0 = Instantiate(moveline,new Vector3(10.379056064025244f,0f,-0.6330752778110489f),Quaternion.Euler(0,8.285074947166478f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(12.879056064025246f,0f,0.6330752778110489f);
skate1.transform.rotation = Quaternion.Euler(0,85.00943237483575f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(12.879056064025246f,0f,0.6330752778110489f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.3251397990263892f);
moveline1 = Instantiate(moveline,new Vector3(12.879056064025246f,0f,0.6330752778110489f),Quaternion.Euler(0,171.7149250528335f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame274 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(10.447619421121296f,0f,-0.663822489034801f);
skate0.transform.rotation = Quaternion.Euler(0,91.5528208543793f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(10.447619421121296f,0f,-0.663822489034801f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.3319000842631233f);
moveline0 = Instantiate(moveline,new Vector3(10.447619421121296f,0f,-0.663822489034801f),Quaternion.Euler(0,4.99056762516426f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(12.947619421121297f,0f,0.663822489034801f);
skate1.transform.rotation = Quaternion.Euler(0,88.4471791456207f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(12.947619421121297f,0f,0.663822489034801f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.3319000842631233f);
moveline1 = Instantiate(moveline,new Vector3(12.947619421121297f,0f,0.663822489034801f),Quaternion.Euler(0,175.00943237483574f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame275 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(10.516231168429785f,0f,-0.6933889740087731f);
skate0.transform.rotation = Quaternion.Euler(0,87.97183463481166f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(10.516231168429785f,0f,-0.6933889740087731f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.33842606782830986f);
moveline0 = Instantiate(moveline,new Vector3(10.516231168429785f,0f,-0.6933889740087731f),Quaternion.Euler(0,1.5528208543793056f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(13.016231168429787f,0f,0.6933889740087731f);
skate1.transform.rotation = Quaternion.Euler(0,92.02816536518834f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(13.016231168429787f,0f,0.6933889740087731f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.33842606782830986f);
moveline1 = Instantiate(moveline,new Vector3(13.016231168429787f,0f,0.6933889740087731f),Quaternion.Euler(0,178.44717914562068f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame276 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(10.58477971793226f,0f,-0.7189292880826913f);
skate0.transform.rotation = Quaternion.Euler(0,84.53408786402672f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(10.58477971793226f,0f,-0.7189292880826913f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.255282153598682f);
moveline0 = Instantiate(moveline,new Vector3(10.58477971793226f,0f,-0.7189292880826913f),Quaternion.Euler(0,-2.0281653651883147f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(13.084779717932262f,0f,0.7189292880826913f);
skate1.transform.rotation = Quaternion.Euler(0,95.46591213597328f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(13.084779717932262f,0f,0.7189292880826913f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.255282153598682f);
moveline1 = Instantiate(moveline,new Vector3(13.084779717932262f,0f,0.7189292880826913f),Quaternion.Euler(0,-177.97183463481167f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame277 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(10.653158171846984f,0f,-0.7404601617376892f);
skate0.transform.rotation = Quaternion.Euler(0,81.23958054202448f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(10.653158171846984f,0f,-0.7404601617376892f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.249833589401217f);
moveline0 = Instantiate(moveline,new Vector3(10.653158171846984f,0f,-0.7404601617376892f),Quaternion.Euler(0,-5.465912135973269f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(13.153158171846986f,0f,0.7404601617376892f);
skate1.transform.rotation = Quaternion.Euler(0,98.76041945797552f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(13.153158171846986f,0f,0.7404601617376892f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.249833589401217f);
moveline1 = Instantiate(moveline,new Vector3(13.153158171846986f,0f,0.7404601617376892f),Quaternion.Euler(0,-174.53408786402673f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame278 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(10.721264655902749f,0f,-0.7580025281909297f);
skate0.transform.rotation = Quaternion.Euler(0,78.08831266880496f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(10.721264655902749f,0f,-0.7580025281909297f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2452302030824125f);
moveline0 = Instantiate(moveline,new Vector3(10.721264655902749f,0f,-0.7580025281909297f),Quaternion.Euler(0,-8.760419457975502f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(13.22126465590275f,0f,0.7580025281909297f);
skate1.transform.rotation = Quaternion.Euler(0,101.91168733119504f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(13.22126465590275f,0f,0.7580025281909297f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2452302030824125f);
moveline1 = Instantiate(moveline,new Vector3(13.22126465590275f,0f,0.7580025281909297f),Quaternion.Euler(0,-171.2395805420245f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame279 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(10.78900256178043f,0f,-0.7715807171910993f);
skate0.transform.rotation = Quaternion.Euler(0,75.08028424436813f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(10.78900256178043f,0f,-0.7715807171910993f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.241472471001613f);
moveline0 = Instantiate(moveline,new Vector3(10.78900256178043f,0f,-0.7715807171910993f),Quaternion.Euler(0,-11.911687331195026f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(13.289002561780432f,0f,0.7715807171910993f);
skate1.transform.rotation = Quaternion.Euler(0,104.91971575563187f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(13.289002561780432f,0f,0.7715807171910993f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.241472471001613f);
moveline1 = Instantiate(moveline,new Vector3(13.289002561780432f,0f,0.7715807171910993f),Quaternion.Euler(0,-168.08831266880497f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame280 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(10.856280708171289f,0f,-0.7812216795017988f);
skate0.transform.rotation = Quaternion.Euler(0,72.21549526871401f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(10.856280708171289f,0f,-0.7812216795017988f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2385594046349255f);
moveline0 = Instantiate(moveline,new Vector3(10.856280708171289f,0f,-0.7812216795017988f),Quaternion.Euler(0,-14.919715755631842f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(13.35628070817129f,0f,0.7812216795017988f);
skate1.transform.rotation = Quaternion.Euler(0,107.78450473128599f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(13.35628070817129f,0f,0.7812216795017988f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2385594046349255f);
moveline1 = Instantiate(moveline,new Vector3(13.35628070817129f,0f,0.7812216795017988f),Quaternion.Euler(0,-165.08028424436813f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame281 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(10.923013429925323f,0f,-0.7869542478264184f);
skate0.transform.rotation = Quaternion.Euler(0,69.4939457418426f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(10.923013429925323f,0f,-0.7869542478264184f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2364886009875002f);
moveline0 = Instantiate(moveline,new Vector3(10.923013429925323f,0f,-0.7869542478264184f),Quaternion.Euler(0,-17.784504731285992f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(13.423013429925325f,0f,0.7869542478264184f);
skate1.transform.rotation = Quaternion.Euler(0,110.5060542581574f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(13.423013429925325f,0f,0.7869542478264184f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2364886009875002f);
moveline1 = Instantiate(moveline,new Vector3(13.423013429925325f,0f,0.7869542478264184f),Quaternion.Euler(0,-162.21549526871402f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame282 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(10.989120604617929f,0f,-0.7888084384755141f);
skate0.transform.rotation = Quaternion.Euler(0,66.91563566375389f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(10.989120604617929f,0f,-0.7888084384755141f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2352563195460307f);
moveline0 = Instantiate(moveline,new Vector3(10.989120604617929f,0f,-0.7888084384755141f),Quaternion.Euler(0,-20.50605425815739f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(13.48912060461793f,0f,0.7888084384755141f);
skate1.transform.rotation = Quaternion.Euler(0,113.08436433624611f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(13.48912060461793f,0f,0.7888084384755141f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2352563195460307f);
moveline1 = Instantiate(moveline,new Vector3(13.48912060461793f,0f,0.7888084384755141f),Quaternion.Euler(0,-159.4939457418426f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame283 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(11.054527625581246f,0f,-0.78681479677959f);
skate0.transform.rotation = Quaternion.Euler(0,64.48056503444789f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(11.054527625581246f,0f,-0.78681479677959f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2348575837688074f);
moveline0 = Instantiate(moveline,new Vector3(11.054527625581246f,0f,-0.78681479677959f),Quaternion.Euler(0,-23.08436433624611f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(13.554527625581247f,0f,0.78681479677959f);
skate1.transform.rotation = Quaternion.Euler(0,115.51943496555211f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(13.554527625581247f,0f,0.78681479677959f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2348575837688074f);
moveline1 = Instantiate(moveline,new Vector3(13.554527625581247f,0f,0.78681479677959f),Quaternion.Euler(0,-156.9156356637539f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame284 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(11.1191653300576f,0f,-0.7810037881085158f);
skate0.transform.rotation = Quaternion.Euler(0,62.1887338539246f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(11.1191653300576f,0f,-0.7810037881085158f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2352863048027531f);
moveline0 = Instantiate(moveline,new Vector3(11.1191653300576f,0f,-0.7810037881085158f),Quaternion.Euler(0,-25.519434965552122f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(13.619165330057601f,0f,0.7810037881085158f);
skate1.transform.rotation = Quaternion.Euler(0,117.8112661460754f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(13.619165330057601f,0f,0.7810037881085158f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2352863048027531f);
moveline1 = Instantiate(moveline,new Vector3(13.619165330057601f,0f,0.7810037881085158f),Quaternion.Euler(0,-154.4805650344479f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame285 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(11.182969890663118f,0f,-0.7714052353717477f);
skate0.transform.rotation = Quaternion.Euler(0,60.04014212218401f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(11.182969890663118f,0f,-0.7714052353717477f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2365354249050697f);
moveline0 = Instantiate(moveline,new Vector3(11.182969890663118f,0f,-0.7714052353717477f),Quaternion.Euler(0,-27.81126614607541f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
skate1.transform.position = new Vector3(13.68296989066312f,0f,0.7714052353717477f);
skate1.transform.rotation = Quaternion.Euler(0,119.95985787781599f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(13.68296989066312f,0f,0.7714052353717477f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2365354249050697f);
moveline1 = Instantiate(moveline,new Vector3(13.68296989066312f,0f,0.7714052353717477f),Quaternion.Euler(0,-152.1887338539246f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
}
}
public class frame286 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(11.245882677823332f,0f,-0.7580478030363235f);
skate0.transform.rotation = Quaternion.Euler(0,58.03478983922613f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(11.245882677823332f,0f,-0.7580478030363235f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2385970779386806f);
moveline0 = Instantiate(moveline,new Vector3(11.245882677823332f,0f,-0.7580478030363235f),Quaternion.Euler(0,-29.959857877815978f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(13.745882677823333f,0f,0.7580478030363235f);
skate1.transform.rotation = Quaternion.Euler(0,121.96521016077386f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(13.745882677823333f,0f,0.7580478030363235f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2385970779386806f);
moveline1 = Instantiate(moveline,new Vector3(13.745882677823333f,0f,0.7580478030363235f),Quaternion.Euler(0,-150.04014212218402f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame287 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(11.30785010027977f,0f,-0.740958527005138f);
skate0.transform.rotation = Quaternion.Euler(0,56.17267700505096f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(11.30785010027977f,0f,-0.740958527005138f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2414627643074279f);
moveline0 = Instantiate(moveline,new Vector3(11.30785010027977f,0f,-0.740958527005138f),Quaternion.Euler(0,-31.965210160773864f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(13.807850100279772f,0f,0.740958527005138f);
skate1.transform.rotation = Quaternion.Euler(0,123.82732299494904f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(13.807850100279772f,0f,0.740958527005138f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2414627643074279f);
moveline1 = Instantiate(moveline,new Vector3(13.807850100279772f,0f,0.740958527005138f),Quaternion.Euler(0,-148.03478983922614f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame288 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(11.368823430184483f,0f,-0.7201623891374509f);
skate0.transform.rotation = Quaternion.Euler(0,54.45380361965849f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(11.368823430184483f,0f,-0.7201623891374509f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.245123537796191f);
moveline0 = Instantiate(moveline,new Vector3(11.368823430184483f,0f,-0.7201623891374509f),Quaternion.Euler(0,-33.82732299494903f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
skate1.transform.position = new Vector3(13.868823430184484f,0f,0.7201623891374509f);
skate1.transform.rotation = Quaternion.Euler(0,125.54619638034151f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(13.868823430184484f,0f,0.7201623891374509f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.245123537796191f);
moveline1 = Instantiate(moveline,new Vector3(13.868823430184484f,0f,0.7201623891374509f),Quaternion.Euler(0,-146.17267700505096f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
}
}
public class frame289 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(11.42875861871226f,0f,-0.695681934756911f);
skate0.transform.rotation = Quaternion.Euler(0,52.878169683048725f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(11.42875861871226f,0f,-0.695681934756911f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2495702019762416f);
moveline0 = Instantiate(moveline,new Vector3(11.42875861871226f,0f,-0.695681934756911f),Quaternion.Euler(0,-35.54619638034151f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(13.928758618712262f,0f,0.695681934756911f);
skate1.transform.rotation = Quaternion.Euler(0,127.12183031695128f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(13.928758618712262f,0f,0.695681934756911f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2495702019762416f);
moveline1 = Instantiate(moveline,new Vector3(13.928758618712262f,0f,0.695681934756911f),Quaternion.Euler(0,-144.4538036196585f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame290 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(11.487616107539806f,0f,-0.667536931168811f);
skate0.transform.rotation = Quaternion.Euler(0,51.445775195221664f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(11.487616107539806f,0f,-0.667536931168811f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2547935141180466f);
moveline0 = Instantiate(moveline,new Vector3(11.487616107539806f,0f,-0.667536931168811f),Quaternion.Euler(0,-37.121830316951275f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(13.987616107539807f,0f,0.667536931168811f);
skate1.transform.rotation = Quaternion.Euler(0,128.55422480477833f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(13.987616107539807f,0f,0.667536931168811f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2547935141180466f);
moveline1 = Instantiate(moveline,new Vector3(13.987616107539807f,0f,0.667536931168811f),Quaternion.Euler(0,-142.87816968304872f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame291 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(11.545360640975955f,0f,-0.6357440649866757f);
skate0.transform.rotation = Quaternion.Euler(0,50.15662015617731f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(11.545360640975955f,0f,-0.6357440649866757f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2607843949118265f);
moveline0 = Instantiate(moveline,new Vector3(11.545360640975955f,0f,-0.6357440649866757f),Quaternion.Euler(0,-38.55422480477836f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(14.045360640975957f,0f,0.6357440649866757f);
skate1.transform.rotation = Quaternion.Euler(0,129.84337984382267f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(14.045360640975957f,0f,0.6357440649866757f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2607843949118265f);
moveline1 = Instantiate(moveline,new Vector3(14.045360640975957f,0f,0.6357440649866757f),Quaternion.Euler(0,-141.44577519522164f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame292 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(11.60196108298419f,0f,-0.6003166759374068f);
skate0.transform.rotation = Quaternion.Euler(0,49.01070456591567f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(11.60196108298419f,0f,-0.6003166759374068f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2675341427196265f);
moveline0 = Instantiate(moveline,new Vector3(11.60196108298419f,0f,-0.6003166759374068f),Quaternion.Euler(0,-39.8433798438227f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(14.101961082984191f,0f,0.6003166759374068f);
skate1.transform.rotation = Quaternion.Euler(0,130.98929543408434f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(14.101961082984191f,0f,0.6003166759374068f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2675341427196265f);
moveline1 = Instantiate(moveline,new Vector3(14.101961082984191f,0f,0.6003166759374068f),Quaternion.Euler(0,-140.1566201561773f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame293 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(11.657390242822405f,0f,-0.5612645247630166f);
skate0.transform.rotation = Quaternion.Euler(0,48.00802842443672f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(11.657390242822405f,0f,-0.5612645247630166f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2750346515615598f);
moveline0 = Instantiate(moveline,new Vector3(11.657390242822405f,0f,-0.5612645247630166f),Quaternion.Euler(0,-40.98929543408431f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(14.157390242822407f,0f,0.5612645247630166f);
skate1.transform.rotation = Quaternion.Euler(0,131.99197157556327f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(14.157390242822407f,0f,0.5612645247630166f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2750346515615598f);
moveline1 = Instantiate(moveline,new Vector3(14.157390242822407f,0f,0.5612645247630166f),Quaternion.Euler(0,-139.0107045659157f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame294 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(11.711624712538256f,0f,-0.5185935928547689f);
skate0.transform.rotation = Quaternion.Euler(0,47.14859173174049f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(11.711624712538256f,0f,-0.5185935928547689f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2832786325652945f);
moveline0 = Instantiate(moveline,new Vector3(11.711624712538256f,0f,-0.5185935928547689f),Quaternion.Euler(0,-41.99197157556327f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(14.211624712538258f,0f,0.5185935928547689f);
skate1.transform.rotation = Quaternion.Euler(0,132.85140826825952f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(14.211624712538258f,0f,0.5185935928547689f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2832786325652945f);
moveline1 = Instantiate(moveline,new Vector3(14.211624712538258f,0f,0.5185935928547689f),Quaternion.Euler(0,-138.00802842443673f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame295 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(11.764644719102204f,0f,-0.47230591133206656f);
skate0.transform.rotation = Quaternion.Euler(0,46.43239448782696f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(11.764644719102204f,0f,-0.47230591133206656f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2922598391767646f);
moveline0 = Instantiate(moveline,new Vector3(11.764644719102204f,0f,-0.47230591133206656f),Quaternion.Euler(0,-42.85140826825949f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(14.264644719102206f,0f,0.47230591133206656f);
skate1.transform.rotation = Quaternion.Euler(0,133.56760551217303f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(14.264644719102206f,0f,0.47230591133206656f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2922598391767646f);
moveline1 = Instantiate(moveline,new Vector3(14.264644719102206f,0f,0.47230591133206656f),Quaternion.Euler(0,-137.1485917317405f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame296 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(11.816433993534611f,0f,-0.42239941740395415f);
skate0.transform.rotation = Quaternion.Euler(0,45.85943669269614f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(11.816433993534611f,0f,-0.42239941740395415f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.301973297040257f);
moveline0 = Instantiate(moveline,new Vector3(11.816433993534611f,0f,-0.42239941740395415f),Quaternion.Euler(0,-43.56760551217303f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(14.316433993534613f,0f,0.42239941740395415f);
skate1.transform.rotation = Quaternion.Euler(0,134.14056330730386f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(14.316433993534613f,0f,0.42239941740395415f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.301973297040257f);
moveline1 = Instantiate(moveline,new Vector3(14.316433993534613f,0f,0.42239941740395415f),Quaternion.Euler(0,-136.43239448782697f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame297 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(11.8670519956479f,0f,-0.3713562726012777f);
skate0.transform.rotation = Quaternion.Euler(0,45.429718346348025f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(11.8670519956479f,0f,-0.3713562726012777f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.31241554011086f);
moveline0 = Instantiate(moveline,new Vector3(11.8670519956479f,0f,-0.3713562726012777f),Quaternion.Euler(0,-135.85943669269614f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.9418332750055924f);
skate1.transform.position = new Vector3(14.367051995647902f,0f,0.3713562726012777f);
skate1.transform.rotation = Quaternion.Euler(0,134.570281653652f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(14.367051995647902f,0f,0.3713562726012777f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.31241554011086f);
moveline1 = Instantiate(moveline,new Vector3(14.367051995647902f,0f,0.3713562726012777f),Quaternion.Euler(0,-44.140563307303864f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.9418332750055924f);
}
}
public class frame298 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(11.918923182837549f,0f,-0.319222634652993f);
skate0.transform.rotation = Quaternion.Euler(0,45.143239448782616f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(11.918923182837549f,0f,-0.319222634652993f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.323066306582754f);
moveline0 = Instantiate(moveline,new Vector3(11.918923182837549f,0f,-0.319222634652993f),Quaternion.Euler(0,135.42971834634804f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(14.41892318283755f,0f,0.319222634652993f);
skate1.transform.rotation = Quaternion.Euler(0,134.85676055121738f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(14.41892318283755f,0f,0.319222634652993f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.323066306582754f);
moveline1 = Instantiate(moveline,new Vector3(14.41892318283755f,0f,0.319222634652993f),Quaternion.Euler(0,44.57028165365197f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame299 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(11.969603386841902f,0f,-0.2659039535975186f);
skate0.transform.rotation = Quaternion.Euler(0,44.99999999999991f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(11.969603386841902f,0f,-0.2659039535975186f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3339178414698867f);
moveline0 = Instantiate(moveline,new Vector3(11.969603386841902f,0f,-0.2659039535975186f),Quaternion.Euler(0,-135.14323944878262f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.9455774571025802f);
skate1.transform.position = new Vector3(14.469603386841904f,0f,0.2659039535975186f);
skate1.transform.rotation = Quaternion.Euler(0,135.00000000000009f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(14.469603386841904f,0f,0.2659039535975186f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3339178414698867f);
moveline1 = Instantiate(moveline,new Vector3(14.469603386841904f,0f,0.2659039535975186f),Quaternion.Euler(0,-44.85676055121738f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.9455774571025802f);
}
}
public class frame300 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(12.021546281526945f,0f,-0.2114461916504596f);
skate0.transform.rotation = Quaternion.Euler(0,44.99999999999991f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(12.021546281526945f,0f,-0.2114461916504596f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.344992080473943f);
moveline0 = Instantiate(moveline,new Vector3(12.021546281526945f,0f,-0.2114461916504596f),Quaternion.Euler(0,134.9999999999999f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(14.521546281526946f,0f,0.2114461916504596f);
skate1.transform.rotation = Quaternion.Euler(0,135.00000000000009f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(14.521546281526946f,0f,0.2114461916504596f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.344992080473943f);
moveline1 = Instantiate(moveline,new Vector3(14.521546281526946f,0f,0.2114461916504596f),Quaternion.Euler(0,45.0000000000001f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame301 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(12.074751866892678f,0f,-0.15797204512631416f);
skate0.transform.rotation = Quaternion.Euler(0,45.14323944878261f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(12.074751866892678f,0f,-0.15797204512631416f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.15628214435495535f);
moveline0 = Instantiate(moveline,new Vector3(12.074751866892678f,0f,-0.15797204512631416f),Quaternion.Euler(0,134.9999999999999f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(14.57475186689268f,0f,0.15797204512631416f);
skate1.transform.rotation = Quaternion.Euler(0,134.8567605512174f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(14.57475186689268f,0f,0.15797204512631416f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.15628214435495535f);
moveline1 = Instantiate(moveline,new Vector3(14.57475186689268f,0f,0.15797204512631416f),Quaternion.Euler(0,45.0000000000001f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame302 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(12.127808032653832f,0f,-0.10434922423407292f);
skate0.transform.rotation = Quaternion.Euler(0,45.42971834634802f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(12.127808032653832f,0f,-0.10434922423407292f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.16735204902591852f);
moveline0 = Instantiate(moveline,new Vector3(12.127808032653832f,0f,-0.10434922423407292f),Quaternion.Euler(0,-135.1432394487826f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.11863123802621897f);
skate1.transform.position = new Vector3(14.627808032653832f,0f,0.10434922423407292f);
skate1.transform.rotation = Quaternion.Euler(0,134.570281653652f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(14.627808032653832f,0f,0.10434922423407292f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.16735204902591852f);
moveline1 = Instantiate(moveline,new Vector3(14.627808032653832f,0f,0.10434922423407292f),Quaternion.Euler(0,-44.856760551217405f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.11863123802621897f);
}
}
public class frame303 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(12.182117383491343f,0f,-0.05167988447894442f);
skate0.transform.rotation = Quaternion.Euler(0,45.859436692696136f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(12.182117383491343f,0f,-0.05167988447894442f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.1784407082590025f);
moveline0 = Instantiate(moveline,new Vector3(12.182117383491343f,0f,-0.05167988447894442f),Quaternion.Euler(0,135.429718346348f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(14.682117383491343f,0f,0.05167988447894442f);
skate1.transform.rotation = Quaternion.Euler(0,134.14056330730386f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(14.682117383491343f,0f,0.05167988447894442f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.1784407082590025f);
moveline1 = Instantiate(moveline,new Vector3(14.682117383491343f,0f,0.05167988447894442f),Quaternion.Euler(0,44.57028165365198f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame304 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(12.236257770711825f,0f,0.001153424525633745f);
skate0.transform.rotation = Quaternion.Euler(0,46.432394487826954f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(12.236257770711825f,0f,0.001153424525633745f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.1893244406824533f);
moveline0 = Instantiate(moveline,new Vector3(12.236257770711825f,0f,0.001153424525633745f),Quaternion.Euler(0,-135.85943669269614f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.1358655491015406f);
skate1.transform.position = new Vector3(14.736257770711825f,0f,-0.001153424525633745f);
skate1.transform.rotation = Quaternion.Euler(0,133.56760551217303f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(14.736257770711825f,0f,-0.001153424525633745f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.1893244406824533f);
moveline1 = Instantiate(moveline,new Vector3(14.736257770711825f,0f,-0.001153424525633745f),Quaternion.Euler(0,-44.140563307303864f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.1358655491015406f);
}
}
public class frame305 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(12.291628890063848f,0f,0.0530504417451457f);
skate0.transform.rotation = Quaternion.Euler(0,47.14859173174048f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(12.291628890063848f,0f,0.0530504417451457f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.20023825035230253f);
moveline0 = Instantiate(moveline,new Vector3(12.291628890063848f,0f,0.0530504417451457f),Quaternion.Euler(0,136.43239448782697f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(14.791628890063848f,0f,-0.0530504417451457f);
skate1.transform.rotation = Quaternion.Euler(0,132.85140826825952f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(14.791628890063848f,0f,-0.0530504417451457f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.20023825035230253f);
moveline1 = Instantiate(moveline,new Vector3(14.791628890063848f,0f,-0.0530504417451457f),Quaternion.Euler(0,43.567605512173046f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame306 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(12.346812182927659f,0f,0.10512170149653935f);
skate0.transform.rotation = Quaternion.Euler(0,48.008028424436716f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(12.346812182927659f,0f,0.10512170149653935f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.2109587101020697f);
moveline0 = Instantiate(moveline,new Vector3(12.346812182927659f,0f,0.10512170149653935f),Quaternion.Euler(0,-137.14859173174048f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.15465803792997262f);
skate1.transform.position = new Vector3(14.846812182927659f,0f,-0.10512170149653935f);
skate1.transform.rotation = Quaternion.Euler(0,131.9919715755633f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(14.846812182927659f,0f,-0.10512170149653935f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.2109587101020697f);
moveline1 = Instantiate(moveline,new Vector3(14.846812182927659f,0f,-0.10512170149653935f),Quaternion.Euler(0,-42.85140826825952f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.15465803792997262f);
}
}
public class frame307 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(12.403190165913834f,0f,0.1562616762258793f);
skate0.transform.rotation = Quaternion.Euler(0,49.01070456591566f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(12.403190165913834f,0f,0.1562616762258793f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.22171896604480942f);
moveline0 = Instantiate(moveline,new Vector3(12.403190165913834f,0f,0.1562616762258793f),Quaternion.Euler(0,138.0080284244367f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(14.903190165913834f,0f,-0.1562616762258793f);
skate1.transform.rotation = Quaternion.Euler(0,130.98929543408434f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(14.903190165913834f,0f,-0.1562616762258793f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.22171896604480942f);
moveline1 = Instantiate(moveline,new Vector3(14.903190165913834f,0f,-0.1562616762258793f),Quaternion.Euler(0,41.99197157556329f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame308 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(12.460739431070028f,0f,0.20646854731465528f);
skate0.transform.rotation = Quaternion.Euler(0,50.156620156177304f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(12.460739431070028f,0f,0.20646854731465528f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.232294099790559f);
moveline0 = Instantiate(moveline,new Vector3(12.460739431070028f,0f,0.20646854731465528f),Quaternion.Euler(0,139.01070456591566f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(14.960739431070028f,0f,-0.20646854731465528f);
skate1.transform.rotation = Quaternion.Euler(0,129.8433798438227f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(14.960739431070028f,0f,-0.20646854731465528f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.232294099790559f);
moveline1 = Instantiate(moveline,new Vector3(14.960739431070028f,0f,-0.20646854731465528f),Quaternion.Euler(0,40.98929543408435f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame309 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(12.519432787654138f,0f,0.2557377186444115f);
skate0.transform.rotation = Quaternion.Euler(0,51.44577519522166f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(12.519432787654138f,0f,0.2557377186444115f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.24268679782413333f);
moveline0 = Instantiate(moveline,new Vector3(12.519432787654138f,0f,0.2557377186444115f),Quaternion.Euler(0,140.1566201561773f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(15.019432787654138f,0f,-0.2557377186444115f);
skate1.transform.rotation = Quaternion.Euler(0,128.55422480477836f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(15.019432787654138f,0f,-0.2557377186444115f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.24268679782413333f);
moveline1 = Instantiate(moveline,new Vector3(15.019432787654138f,0f,-0.2557377186444115f),Quaternion.Euler(0,39.8433798438227f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame310 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(12.579239099629643f,0f,0.3040620331103536f);
skate0.transform.rotation = Quaternion.Euler(0,52.87816968304872f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(12.579239099629643f,0f,0.3040620331103536f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.25289881401198866f);
moveline0 = Instantiate(moveline,new Vector3(12.579239099629643f,0f,0.3040620331103536f),Quaternion.Euler(0,141.44577519522164f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(15.079239099629643f,0f,-0.3040620331103536f);
skate1.transform.rotation = Quaternion.Euler(0,127.12183031695128f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(15.079239099629643f,0f,-0.3040620331103536f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.25289881401198866f);
moveline1 = Instantiate(moveline,new Vector3(15.079239099629643f,0f,-0.3040620331103536f),Quaternion.Euler(0,38.55422480477835f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame311 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(12.64012311130538f,0f,0.3514320207651983f);
skate0.transform.rotation = Quaternion.Euler(0,54.45380361965848f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(12.64012311130538f,0f,0.3514320207651983f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.2629310279010488f);
moveline0 = Instantiate(moveline,new Vector3(12.64012311130538f,0f,0.3514320207651983f),Quaternion.Euler(0,142.87816968304872f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(15.14012311130538f,0f,-0.3514320207651983f);
skate1.transform.rotation = Quaternion.Euler(0,125.54619638034151f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(15.14012311130538f,0f,-0.3514320207651983f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.2629310279010488f);
moveline1 = Instantiate(moveline,new Vector3(15.14012311130538f,0f,-0.3514320207651983f),Quaternion.Euler(0,37.12183031695128f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame312 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(12.702045264358052f,0f,0.3978361806724633f);
skate0.transform.rotation = Quaternion.Euler(0,56.17267700505095f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(12.702045264358052f,0f,0.3978361806724633f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.2727835065767086f);
moveline0 = Instantiate(moveline,new Vector3(12.702045264358052f,0f,0.3978361806724633f),Quaternion.Euler(0,144.4538036196585f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(15.202045264358052f,0f,-0.3978361806724633f);
skate1.transform.rotation = Quaternion.Euler(0,123.82732299494904f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(15.202045264358052f,0f,-0.3978361806724633f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.2727835065767086f);
moveline1 = Instantiate(moveline,new Vector3(15.202045264358052f,0f,-0.3978361806724633f),Quaternion.Euler(0,35.54619638034152f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame313 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(12.76496150996245f,0f,0.443261298580921f);
skate0.transform.rotation = Quaternion.Euler(0,58.03478983922612f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(12.76496150996245f,0f,0.443261298580921f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.28245557131264853f);
moveline0 = Instantiate(moveline,new Vector3(12.76496150996245f,0f,0.443261298580921f),Quaternion.Euler(0,146.17267700505096f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(15.26496150996245f,0f,-0.443261298580921f);
skate1.transform.rotation = Quaternion.Euler(0,121.96521016077388f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(15.26496150996245f,0f,-0.443261298580921f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.28245557131264853f);
moveline1 = Instantiate(moveline,new Vector3(15.26496150996245f,0f,-0.443261298580921f),Quaternion.Euler(0,33.82732299494905f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame314 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(12.828823120270624f,0f,0.48769280249817043f);
skate0.transform.rotation = Quaternion.Euler(0,60.04014212218401f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(12.828823120270624f,0f,0.48769280249817043f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.29194587024226926f);
moveline0 = Instantiate(moveline,new Vector3(12.828823120270624f,0f,0.48769280249817043f),Quaternion.Euler(0,148.03478983922614f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(15.328823120270624f,0f,-0.48769280249817043f);
skate1.transform.rotation = Quaternion.Euler(0,119.95985787781599f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(15.328823120270624f,0f,-0.48769280249817043f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.29194587024226926f);
moveline1 = Instantiate(moveline,new Vector3(15.328823120270624f,0f,-0.48769280249817043f),Quaternion.Euler(0,31.96521016077387f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame315 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(12.893576504024102f,0f,0.5311151581314179f);
skate0.transform.rotation = Quaternion.Euler(0,62.18873385392459f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(12.893576504024102f,0f,0.5311151581314179f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.3012524582675836f);
moveline0 = Instantiate(moveline,new Vector3(12.893576504024102f,0f,0.5311151581314179f),Quaternion.Euler(0,150.04014212218402f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(15.393576504024102f,0f,-0.5311151581314179f);
skate1.transform.rotation = Quaternion.Euler(0,117.81126614607541f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(15.393576504024102f,0f,-0.5311151581314179f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.3012524582675836f);
moveline1 = Instantiate(moveline,new Vector3(15.393576504024102f,0f,-0.5311151581314179f),Quaternion.Euler(0,29.959857877815992f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame316 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(12.959163031648416f,0f,0.5735123059673567f);
skate0.transform.rotation = Quaternion.Euler(0,64.48056503444789f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(12.959163031648416f,0f,0.5735123059673567f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.31037288539073604f);
moveline0 = Instantiate(moveline,new Vector3(12.959163031648416f,0f,0.5735123059673567f),Quaternion.Euler(0,152.1887338539246f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(15.459163031648416f,0f,-0.5735123059673567f);
skate1.transform.rotation = Quaternion.Euler(0,115.51943496555211f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(15.459163031648416f,0f,-0.5735123059673567f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.31037288539073604f);
moveline1 = Instantiate(moveline,new Vector3(15.459163031648416f,0f,-0.5735123059673567f),Quaternion.Euler(0,27.81126614607542f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame317 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(13.025518875759692f,0f,0.6148681414699364f);
skate0.transform.rotation = Quaternion.Euler(0,66.91563566375389f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(13.025518875759692f,0f,0.6148681414699364f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.319304294600225f);
moveline0 = Instantiate(moveline,new Vector3(13.025518875759692f,0f,0.6148681414699364f),Quaternion.Euler(0,154.48056503444786f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(15.525518875759692f,0f,-0.6148681414699364f);
skate1.transform.rotation = Quaternion.Euler(0,113.08436433624611f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(15.525518875759692f,0f,-0.6148681414699364f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.319304294600225f);
moveline1 = Instantiate(moveline,new Vector3(15.525518875759692f,0f,-0.6148681414699364f),Quaternion.Euler(0,25.519434965552122f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame318 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(13.092574873600258f,0f,0.6551670394741597f);
skate0.transform.rotation = Quaternion.Euler(0,69.4939457418426f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(13.092574873600258f,0f,0.6551670394741597f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.32804353036256906f);
moveline0 = Instantiate(moveline,new Vector3(13.092574873600258f,0f,0.6551670394741597f),Quaternion.Euler(0,156.91563566375387f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(15.592574873600258f,0f,-0.6551670394741597f);
skate1.transform.rotation = Quaternion.Euler(0,110.5060542581574f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(15.592574873600258f,0f,-0.6551670394741597f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.32804353036256906f);
moveline1 = Instantiate(moveline,new Vector3(15.592574873600258f,0f,-0.6551670394741597f),Quaternion.Euler(0,23.084364336246125f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame319 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(13.160256418502252f,0f,0.6943944233353605f);
skate0.transform.rotation = Quaternion.Euler(0,72.215495268714f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(13.160256418502252f,0f,0.6943944233353605f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.3365872586548713f);
moveline0 = Instantiate(moveline,new Vector3(13.160256418502252f,0f,0.6943944233353605f),Quaternion.Euler(0,159.4939457418426f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(15.660256418502252f,0f,-0.6943944233353605f);
skate1.transform.rotation = Quaternion.Euler(0,107.784504731286f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(15.660256418502252f,0f,-0.6943944233353605f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.3365872586548713f);
moveline1 = Instantiate(moveline,new Vector3(15.660256418502252f,0f,-0.6943944233353605f),Quaternion.Euler(0,20.506054258157405f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame320 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(13.22848338804107f,0f,0.7325373787467434f);
skate0.transform.rotation = Quaternion.Euler(0,75.08028424436812f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(13.22848338804107f,0f,0.7325373787467434f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.3449320993191213f);
moveline0 = Instantiate(moveline,new Vector3(13.22848338804107f,0f,0.7325373787467434f),Quaternion.Euler(0,162.215495268714f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(15.72848338804107f,0f,-0.7325373787467434f);
skate1.transform.rotation = Quaternion.Euler(0,104.91971575563188f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(15.72848338804107f,0f,-0.7325373787467434f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.3449320993191213f);
moveline1 = Instantiate(moveline,new Vector3(15.72848338804107f,0f,-0.7325373787467434f),Quaternion.Euler(0,17.784504731285992f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame321 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(13.297170117066711f,0f,0.7695853113542905f);
skate0.transform.rotation = Quaternion.Euler(0,78.08831266880495f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(13.297170117066711f,0f,0.7695853113542905f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.3530747713203935f);
moveline0 = Instantiate(moveline,new Vector3(13.297170117066711f,0f,0.7695853113542905f),Quaternion.Euler(0,165.0802842443681f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(15.797170117066711f,0f,-0.7695853113542905f);
skate1.transform.rotation = Quaternion.Euler(0,101.91168733119505f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(15.797170117066711f,0f,-0.7695853113542905f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.3530747713203935f);
moveline1 = Instantiate(moveline,new Vector3(15.797170117066711f,0f,-0.7695853113542905f),Quaternion.Euler(0,14.919715755631884f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame322 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(13.366225424270436f,0f,0.8055306463699209f);
skate0.transform.rotation = Quaternion.Euler(0,81.23958054202447f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(13.366225424270436f,0f,0.8055306463699209f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.3610122512446027f);
moveline0 = Instantiate(moveline,new Vector3(13.366225424270436f,0f,0.8055306463699209f),Quaternion.Euler(0,168.08831266880495f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(15.866225424270436f,0f,-0.8055306463699209f);
skate1.transform.rotation = Quaternion.Euler(0,98.76041945797553f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(15.866225424270436f,0f,-0.8055306463699209f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.3610122512446027f);
moveline1 = Instantiate(moveline,new Vector3(15.866225424270436f,0f,-0.8055306463699209f),Quaternion.Euler(0,11.911687331195054f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame323 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(13.435552701333119f,0f,0.8403695673055029f);
skate0.transform.rotation = Quaternion.Euler(0,84.5340878640267f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(13.435552701333119f,0f,0.8403695673055029f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.368741945074805f);
moveline0 = Instantiate(moveline,new Vector3(13.435552701333119f,0f,0.8403695673055029f),Quaternion.Euler(0,171.23958054202447f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(15.935552701333119f,0f,-0.8403695673055029f);
skate1.transform.rotation = Quaternion.Euler(0,95.4659121359733f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(15.935552701333119f,0f,-0.8403695673055029f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.368741945074805f);
moveline1 = Instantiate(moveline,new Vector3(15.935552701333119f,0f,-0.8403695673055029f),Quaternion.Euler(0,8.76041945797553f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame324 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(13.505050073983554f,0f,0.8741027897191985f);
skate0.transform.rotation = Quaternion.Euler(0,87.97183463481164f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(13.505050073983554f,0f,0.8741027897191985f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.3762618729376272f);
moveline0 = Instantiate(moveline,new Vector3(13.505050073983554f,0f,0.8741027897191985f),Quaternion.Euler(0,174.53408786402673f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
skate1.transform.position = new Vector3(16.005050073983554f,0f,-0.8741027897191985f);
skate1.transform.rotation = Quaternion.Euler(0,92.02816536518836f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(16.005050073983554f,0f,-0.8741027897191985f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.3762618729376272f);
moveline1 = Instantiate(moveline,new Vector3(16.005050073983554f,0f,-0.8741027897191985f),Quaternion.Euler(0,5.465912135973284f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
}
}
public class frame325 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(13.574610644440003f,0f,0.9067363644823287f);
skate0.transform.rotation = Quaternion.Euler(0,91.55282085437929f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(13.574610644440003f,0f,0.9067363644823287f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.3835708661149241f);
moveline0 = Instantiate(moveline,new Vector3(13.574610644440003f,0f,0.9067363644823287f),Quaternion.Euler(0,177.97183463481164f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(16.074610644440003f,0f,-0.9067363644823287f);
skate1.transform.rotation = Quaternion.Euler(0,88.44717914562071f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(16.074610644440003f,0f,-0.9067363644823287f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.3835708661149241f);
moveline1 = Instantiate(moveline,new Vector3(16.074610644440003f,0f,-0.9067363644823287f),Quaternion.Euler(0,2.0281653651883573f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame326 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(13.644122824684015f,0f,0.9354253606873685f);
skate0.transform.rotation = Quaternion.Euler(0,94.99056762516423f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(13.644122824684015f,0f,0.9354253606873685f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2093312248255486f);
moveline0 = Instantiate(moveline,new Vector3(13.644122824684015f,0f,0.9354253606873685f),Quaternion.Euler(0,-178.44717914562074f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(16.144122824684015f,0f,-0.9354253606873685f);
skate1.transform.rotation = Quaternion.Euler(0,85.00943237483577f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(16.144122824684015f,0f,-0.9354253606873685f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2093312248255486f);
moveline1 = Instantiate(moveline,new Vector3(16.144122824684015f,0f,-0.9354253606873685f),Quaternion.Euler(0,-1.5528208543792914f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame327 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(13.71347966253156f,0f,0.9601870760211815f);
skate0.transform.rotation = Quaternion.Euler(0,98.28507494716646f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(13.71347966253156f,0f,0.9601870760211815f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2030682551935363f);
moveline0 = Instantiate(moveline,new Vector3(13.71347966253156f,0f,0.9601870760211815f),Quaternion.Euler(0,-175.0094323748358f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(16.213479662531558f,0f,-0.9601870760211815f);
skate1.transform.rotation = Quaternion.Euler(0,81.71492505283354f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(16.213479662531558f,0f,-0.9601870760211815f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2030682551935363f);
moveline1 = Instantiate(moveline,new Vector3(16.213479662531558f,0f,-0.9601870760211815f),Quaternion.Euler(0,-4.990567625164232f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame328 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(13.782579181748329f,0f,0.9810430627457498f);
skate0.transform.rotation = Quaternion.Euler(0,101.436342820386f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(13.782579181748329f,0f,0.9810430627457498f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.19764466214458f);
moveline0 = Instantiate(moveline,new Vector3(13.782579181748329f,0f,0.9810430627457498f),Quaternion.Euler(0,-171.71492505283356f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(16.28257918174833f,0f,-0.9810430627457498f);
skate1.transform.rotation = Quaternion.Euler(0,78.563657179614f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(16.28257918174833f,0f,-0.9810430627457498f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.19764466214458f);
moveline1 = Instantiate(moveline,new Vector3(16.28257918174833f,0f,-0.9810430627457498f),Quaternion.Euler(0,-8.28507494716645f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame329 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(13.85132463116435f,0f,0.998018319435352f);
skate0.transform.rotation = Quaternion.Euler(0,104.44437124482282f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(13.85132463116435f,0f,0.998018319435352f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1930632165731634f);
moveline0 = Instantiate(moveline,new Vector3(13.85132463116435f,0f,0.998018319435352f),Quaternion.Euler(0,-168.56365717961398f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(16.35132463116435f,0f,-0.998018319435352f);
skate1.transform.rotation = Quaternion.Euler(0,75.55562875517718f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(16.35132463116435f,0f,-0.998018319435352f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1930632165731634f);
moveline1 = Instantiate(moveline,new Vector3(16.35132463116435f,0f,-0.998018319435352f),Quaternion.Euler(0,-11.436342820386002f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame330 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(13.91962465217525f,0f,1.0111405130935576f);
skate0.transform.rotation = Quaternion.Euler(0,107.30916022047694f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(13.91962465217525f,0f,1.0111405130935576f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1893250183755135f);
moveline0 = Instantiate(moveline,new Vector3(13.91962465217525f,0f,1.0111405130935576f),Quaternion.Euler(0,-165.55562875517717f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(16.419624652175248f,0f,-1.0111405130935576f);
skate1.transform.rotation = Quaternion.Euler(0,72.69083977952306f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(16.419624652175248f,0f,-1.0111405130935576f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1893250183755135f);
moveline1 = Instantiate(moveline,new Vector3(16.419624652175248f,0f,-1.0111405130935576f),Quaternion.Euler(0,-14.444371244822818f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame331 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(13.987393374054683f,0f,1.020439237527505f);
skate0.transform.rotation = Quaternion.Euler(0,110.03070974734834f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(13.987393374054683f,0f,1.020439237527505f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1864295213910636f);
moveline0 = Instantiate(moveline,new Vector3(13.987393374054683f,0f,1.020439237527505f),Quaternion.Euler(0,-162.69083977952306f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(16.48739337405468f,0f,-1.020439237527505f);
skate1.transform.rotation = Quaternion.Euler(0,69.96929025265166f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(16.48739337405468f,0f,-1.020439237527505f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1864295213910636f);
moveline1 = Instantiate(moveline,new Vector3(16.48739337405468f,0f,-1.020439237527505f),Quaternion.Euler(0,-17.30916022047694f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame332 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(14.05455044636902f,0f,1.0259453123996745f);
skate0.transform.rotation = Quaternion.Euler(0,112.60901982543706f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(14.05455044636902f,0f,1.0259453123996745f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.184374586857374f);
moveline0 = Instantiate(moveline,new Vector3(14.05455044636902f,0f,1.0259453123996745f),Quaternion.Euler(0,-159.9692902526517f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(16.554550446369017f,0f,-1.0259453123996745f);
skate1.transform.rotation = Quaternion.Euler(0,67.39098017456294f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(16.554550446369017f,0f,-1.0259453123996745f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.184374586857374f);
moveline1 = Instantiate(moveline,new Vector3(16.554550446369017f,0f,-1.0259453123996745f),Quaternion.Euler(0,-20.03070974734834f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame333 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(14.121021017513952f,0f,1.027690126072851f);
skate0.transform.rotation = Quaternion.Euler(0,115.04409045474306f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(14.121021017513952f,0f,1.027690126072851f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1831565637041597f);
moveline0 = Instantiate(moveline,new Vector3(14.121021017513952f,0f,1.027690126072851f),Quaternion.Euler(0,-157.3909801745629f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(16.621021017513947f,0f,-1.027690126072851f);
skate1.transform.rotation = Quaternion.Euler(0,64.95590954525694f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(16.621021017513947f,0f,-1.027690126072851f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1831565637041597f);
moveline1 = Instantiate(moveline,new Vector3(16.621021017513947f,0f,-1.027690126072851f),Quaternion.Euler(0,-22.609019825437045f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame334 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(14.186735668012853f,0f,1.0257050242146464f);
skate0.transform.rotation = Quaternion.Euler(0,117.33592163526635f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(14.186735668012853f,0f,1.0257050242146464f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1827703935752523f);
moveline0 = Instantiate(moveline,new Vector3(14.186735668012853f,0f,1.0257050242146464f),Quaternion.Euler(0,-154.95590954525696f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(16.686735668012847f,0f,-1.0257050242146464f);
skate1.transform.rotation = Quaternion.Euler(0,62.664078364733655f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(16.686735668012847f,0f,-1.0257050242146464f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1827703935752523f);
moveline1 = Instantiate(moveline,new Vector3(16.686735668012847f,0f,-1.0257050242146464f),Quaternion.Euler(0,-25.044090454743042f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame335 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(14.251630306755326f,0f,1.0200207451324366f);
skate0.transform.rotation = Quaternion.Euler(0,119.48451336700694f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(14.251630306755326f,0f,1.0200207451324366f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1832097381211153f);
moveline0 = Instantiate(moveline,new Vector3(14.251630306755326f,0f,1.0200207451324366f),Quaternion.Euler(0,-152.66407836473365f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(16.75163030675532f,0f,-1.0200207451324366f);
skate1.transform.rotation = Quaternion.Euler(0,60.51548663299307f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(16.75163030675532f,0f,-1.0200207451324366f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1832097381211153f);
moveline1 = Instantiate(moveline,new Vector3(16.75163030675532f,0f,-1.0200207451324366f),Quaternion.Euler(0,-27.335921635266345f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame336 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(14.31564603783477f,0f,1.0106669019635883f);
skate0.transform.rotation = Quaternion.Euler(0,121.48986564996481f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(14.31564603783477f,0f,1.0106669019635883f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1844671258613204f);
moveline0 = Instantiate(moveline,new Vector3(14.31564603783477f,0f,1.0106669019635883f),Quaternion.Euler(0,-150.5154866329931f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(16.815646037834764f,0f,-1.0106669019635883f);
skate1.transform.rotation = Quaternion.Euler(0,58.51013435003519f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(16.815646037834764f,0f,-1.0106669019635883f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1844671258613204f);
moveline1 = Instantiate(moveline,new Vector3(16.815646037834764f,0f,-1.0106669019635883f),Quaternion.Euler(0,-29.48451336700691f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame337 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(14.378729005086628f,0f,0.9976715111426286f);
skate0.transform.rotation = Quaternion.Euler(0,123.35197848413999f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(14.378729005086628f,0f,0.9976715111426286f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1865341157826124f);
moveline0 = Instantiate(moveline,new Vector3(14.378729005086628f,0f,0.9976715111426286f),Quaternion.Euler(0,-148.5101343500352f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(16.878729005086623f,0f,-0.9976715111426286f);
skate1.transform.rotation = Quaternion.Euler(0,56.64802151586001f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(16.878729005086623f,0f,-0.9976715111426286f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1865341157826124f);
moveline1 = Instantiate(moveline,new Vector3(16.878729005086623f,0f,-0.9976715111426286f),Quaternion.Euler(0,-31.4898656499648f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame338 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(14.440830220851335f,0f,0.9810605659981306f);
skate0.transform.rotation = Quaternion.Euler(0,125.07085186953246f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(14.440830220851335f,0f,0.9810605659981306f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1894014748146033f);
moveline0 = Instantiate(moveline,new Vector3(14.440830220851335f,0f,0.9810605659981306f),Quaternion.Euler(0,-146.64802151586005f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(16.94083022085133f,0f,-0.9810605659981306f);
skate1.transform.rotation = Quaternion.Euler(0,54.92914813046754f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(16.94083022085133f,0f,-0.9810605659981306f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1894014748146033f);
moveline1 = Instantiate(moveline,new Vector3(16.94083022085133f,0f,-0.9810605659981306f),Quaternion.Euler(0,-33.35197848413996f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame339 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(14.501905384902374f,0f,0.9608576538878153f);
skate0.transform.rotation = Quaternion.Euler(0,126.64648580614222f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(14.501905384902374f,0f,0.9608576538878153f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.193059366407583f);
moveline0 = Instantiate(moveline,new Vector3(14.501905384902374f,0f,0.9608576538878153f),Quaternion.Euler(0,-144.92914813046755f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(17.00190538490237f,0f,-0.9608576538878153f);
skate1.transform.rotation = Quaternion.Euler(0,53.35351419385778f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(17.00190538490237f,0f,-0.9608576538878153f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.193059366407583f);
moveline1 = Instantiate(moveline,new Vector3(17.00190538490237f,0f,-0.9608576538878153f),Quaternion.Euler(0,-35.07085186953246f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame340 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(14.561914698901875f,0f,0.9370836149502118f);
skate0.transform.rotation = Quaternion.Euler(0,128.0788802939693f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(14.561914698901875f,0f,0.9370836149502118f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1974975476172953f);
moveline0 = Instantiate(moveline,new Vector3(14.561914698901875f,0f,0.9370836149502118f),Quaternion.Euler(0,-143.3535141938578f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(17.06191469890187f,0f,-0.9370836149502118f);
skate1.transform.rotation = Quaternion.Euler(0,51.921119706030716f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(17.06191469890187f,0f,-0.9370836149502118f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1974975476172953f);
moveline1 = Instantiate(moveline,new Vector3(17.06191469890187f,0f,-0.9370836149502118f),Quaternion.Euler(0,-36.646485806142195f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame341 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(14.62082268118287f,0f,0.9097562403242602f);
skate0.transform.rotation = Quaternion.Euler(0,129.36803533301364f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(14.62082268118287f,0f,0.9097562403242602f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2027055723688231f);
moveline0 = Instantiate(moveline,new Vector3(14.62082268118287f,0f,0.9097562403242602f),Quaternion.Euler(0,-141.9211197060307f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(17.120822681182865f,0f,-0.9097562403242602f);
skate1.transform.rotation = Quaternion.Euler(0,50.63196466698637f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(17.120822681182865f,0f,-0.9097562403242602f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2027055723688231f);
moveline1 = Instantiate(moveline,new Vector3(17.120822681182865f,0f,-0.9097562403242602f),Quaternion.Euler(0,-38.07888029396926f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame342 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(14.678597986115417f,0f,0.8788900075534696f);
skate0.transform.rotation = Quaternion.Euler(0,130.51395092327527f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(14.678597986115417f,0f,0.8788900075534696f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2086729989133729f);
moveline0 = Instantiate(moveline,new Vector3(14.678597986115417f,0f,0.8788900075534696f),Quaternion.Euler(0,-140.63196466698636f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(17.17859798611541f,0f,-0.8788900075534696f);
skate1.transform.rotation = Quaternion.Euler(0,49.48604907672472f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(17.17859798611541f,0f,-0.8788900075534696f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2086729989133729f);
moveline1 = Instantiate(moveline,new Vector3(17.17859798611541f,0f,-0.8788900075534696f),Quaternion.Euler(0,-39.36803533301364f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame343 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(14.735213231798f,0f,0.8444958508377762f);
skate0.transform.rotation = Quaternion.Euler(0,131.51662706475423f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(14.735213231798f,0f,0.8444958508377762f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2153895998947462f);
moveline0 = Instantiate(moveline,new Vector3(14.735213231798f,0f,0.8444958508377762f),Quaternion.Euler(0,-139.48604907672475f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(17.235213231797992f,0f,-0.8444958508377762f);
skate1.transform.rotation = Quaternion.Euler(0,48.48337293524578f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(17.235213231797992f,0f,-0.8444958508377762f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2153895998947462f);
moveline1 = Instantiate(moveline,new Vector3(17.235213231797992f,0f,-0.8444958508377762f),Quaternion.Euler(0,-40.513950923275246f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame344 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(14.790644839328737f,0f,0.8065809638135418f);
skate0.transform.rotation = Quaternion.Euler(0,132.37606375745045f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(14.790644839328737f,0f,0.8065809638135418f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2228455738943498f);
moveline0 = Instantiate(moveline,new Vector3(14.790644839328737f,0f,0.8065809638135418f),Quaternion.Euler(0,-138.48337293524577f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(17.29064483932873f,0f,-0.8065809638135418f);
skate1.transform.rotation = Quaternion.Euler(0,47.62393624254955f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(17.29064483932873f,0f,-0.8065809638135418f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2228455738943498f);
moveline1 = Instantiate(moveline,new Vector3(17.29064483932873f,0f,-0.8065809638135418f),Quaternion.Euler(0,-41.51662706475423f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame345 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(14.844872886454052f,0f,0.7651486326200821f);
skate0.transform.rotation = Quaternion.Euler(0,133.09226100136397f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(14.844872886454052f,0f,0.7651486326200821f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2310317578141114f);
moveline0 = Instantiate(moveline,new Vector3(14.844872886454052f,0f,0.7651486326200821f),Quaternion.Euler(0,-137.62393624254955f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(17.344872886454045f,0f,-0.7651486326200821f);
skate1.transform.rotation = Quaternion.Euler(0,46.90773899863602f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(17.344872886454045f,0f,-0.7651486326200821f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2310317578141114f);
moveline1 = Instantiate(moveline,new Vector3(17.344872886454045f,0f,-0.7651486326200821f),Quaternion.Euler(0,-42.37606375745045f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame346 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(14.897880977965627f,0f,0.7201980971401686f);
skate0.transform.rotation = Quaternion.Euler(0,133.6652187964948f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(14.897880977965627f,0f,0.7201980971401686f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2399398399776504f);
moveline0 = Instantiate(moveline,new Vector3(14.897880977965627f,0f,0.7201980971401686f),Quaternion.Euler(0,-136.90773899863603f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
skate1.transform.position = new Vector3(17.39788097796562f,0f,-0.7201980971401686f);
skate1.transform.rotation = Quaternion.Euler(0,46.334781203505194f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(17.39788097796562f,0f,-0.7201980971401686f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2399398399776504f);
moveline1 = Instantiate(moveline,new Vector3(17.39788097796562f,0f,-0.7201980971401686f),Quaternion.Euler(0,-43.092261001363966f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
}
}
public class frame347 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(14.949656134818063f,0f,0.6717244384730863f);
skate0.transform.rotation = Quaternion.Euler(0,134.09493714284292f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(14.949656134818063f,0f,0.6717244384730863f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2495625743767127f);
moveline0 = Instantiate(moveline,new Vector3(14.949656134818063f,0f,0.6717244384730863f),Quaternion.Euler(0,-136.3347812035052f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(17.449656134818056f,0f,-0.6717244384730863f);
skate1.transform.rotation = Quaternion.Euler(0,45.90506285715708f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(17.449656134818056f,0f,-0.6717244384730863f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2495625743767127f);
moveline1 = Instantiate(moveline,new Vector3(17.449656134818056f,0f,-0.6717244384730863f),Quaternion.Euler(0,-43.6652187964948f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame348 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(15.000188703567458f,0f,0.6197184909036288f);
skate0.transform.rotation = Quaternion.Euler(0,134.38141604040834f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(15.000188703567458f,0f,0.6197184909036288f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2598939970613938f);
moveline0 = Instantiate(moveline,new Vector3(15.000188703567458f,0f,0.6197184909036288f),Quaternion.Euler(0,-135.90506285715708f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(17.500188703567453f,0f,-0.6197184909036288f);
skate1.transform.rotation = Quaternion.Euler(0,45.61858395959167f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(17.500188703567453f,0f,-0.6197184909036288f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2598939970613938f);
moveline1 = Instantiate(moveline,new Vector3(17.500188703567453f,0f,-0.6197184909036288f),Quaternion.Euler(0,-44.09493714284292f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame349 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(15.051970257251824f,0f,0.5667192753564495f);
skate0.transform.rotation = Quaternion.Euler(0,134.52465548919105f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(15.051970257251824f,0f,0.5667192753564495f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2709296462726f);
moveline0 = Instantiate(moveline,new Vector3(15.051970257251824f,0f,0.5667192753564495f),Quaternion.Euler(0,44.38141604040833f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(17.551970257251817f,0f,-0.5667192753564495f);
skate1.transform.rotation = Quaternion.Euler(0,45.475344510808966f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(17.551970257251817f,0f,-0.5667192753564495f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2709296462726f);
moveline1 = Instantiate(moveline,new Vector3(17.551970257251817f,0f,-0.5667192753564495f),Quaternion.Euler(0,135.61858395959166f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame350 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(15.105003982587881f,0f,0.5127036673041253f);
skate0.transform.rotation = Quaternion.Euler(0,134.52465548919105f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(15.105003982587881f,0f,0.5127036673041253f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2821285711069301f);
moveline0 = Instantiate(moveline,new Vector3(15.105003982587881f,0f,0.5127036673041253f),Quaternion.Euler(0,44.52465548919104f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(17.605003982587874f,0f,-0.5127036673041253f);
skate1.transform.rotation = Quaternion.Euler(0,45.475344510808966f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(17.605003982587874f,0f,-0.5127036673041253f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2821285711069301f);
moveline1 = Instantiate(moveline,new Vector3(17.605003982587874f,0f,-0.5127036673041253f),Quaternion.Euler(0,135.47534451080895f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame351 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(15.159289879575628f,0f,0.45979422230550354f);
skate0.transform.rotation = Quaternion.Euler(0,134.38141604040834f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(15.159289879575628f,0f,0.45979422230550354f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.09349745815241821f);
moveline0 = Instantiate(moveline,new Vector3(15.159289879575628f,0f,0.45979422230550354f),Quaternion.Euler(0,44.52465548919104f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(17.65928987957562f,0f,-0.45979422230550354f);
skate1.transform.rotation = Quaternion.Euler(0,45.618583959591675f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(17.65928987957562f,0f,-0.45979422230550354f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.09349745815241821f);
moveline1 = Instantiate(moveline,new Vector3(17.65928987957562f,0f,-0.45979422230550354f),Quaternion.Euler(0,135.47534451080895f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame352 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(15.21348241078927f,0f,0.4067934060911864f);
skate0.transform.rotation = Quaternion.Euler(0,134.09493714284292f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(15.21348241078927f,0f,0.4067934060911864f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.10459404915518293f);
moveline0 = Instantiate(moveline,new Vector3(15.21348241078927f,0f,0.4067934060911864f),Quaternion.Euler(0,-44.38141604040831f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.07475332287079205f);
skate1.transform.position = new Vector3(17.713482410789265f,0f,-0.4067934060911864f);
skate1.transform.rotation = Quaternion.Euler(0,45.905062857157084f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(17.713482410789265f,0f,-0.4067934060911864f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.10459404915518293f);
moveline1 = Instantiate(moveline,new Vector3(17.713482410789265f,0f,-0.4067934060911864f),Quaternion.Euler(0,-135.61858395959166f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.07475332287079205f);
}
}
public class frame353 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(15.267571712381397f,0f,0.35369257110053254f);
skate0.transform.rotation = Quaternion.Euler(0,133.6652187964948f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(15.267571712381397f,0f,0.35369257110053254f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.11567489860863045f);
moveline0 = Instantiate(moveline,new Vector3(15.267571712381397f,0f,0.35369257110053254f),Quaternion.Euler(0,-44.094937142842895f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.0830762995899337f);
skate1.transform.position = new Vector3(17.767571712381393f,0f,-0.35369257110053254f);
skate1.transform.rotation = Quaternion.Euler(0,46.3347812035052f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(17.767571712381393f,0f,-0.35369257110053254f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.11567489860863045f);
moveline1 = Instantiate(moveline,new Vector3(17.767571712381393f,0f,-0.35369257110053254f),Quaternion.Euler(0,-135.9050628571571f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.0830762995899337f);
}
}
public class frame354 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(15.322893948632663f,0f,0.3016571657414148f);
skate0.transform.rotation = Quaternion.Euler(0,133.09226100136397f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(15.322893948632663f,0f,0.3016571657414148f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.12674581677755606f);
moveline0 = Instantiate(moveline,new Vector3(15.322893948632663f,0f,0.3016571657414148f),Quaternion.Euler(0,43.6652187964948f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(17.82289394863266f,0f,-0.3016571657414148f);
skate1.transform.rotation = Quaternion.Euler(0,46.90773899863603f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(17.82289394863266f,0f,-0.3016571657414148f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.12674581677755606f);
moveline1 = Instantiate(moveline,new Vector3(17.82289394863266f,0f,-0.3016571657414148f),Quaternion.Euler(0,136.3347812035052f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame355 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(15.378093627979647f,0f,0.2495071047057295f);
skate0.transform.rotation = Quaternion.Euler(0,132.37606375745045f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(15.378093627979647f,0f,0.2495071047057295f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.13756864978448835f);
moveline0 = Instantiate(moveline,new Vector3(15.378093627979647f,0f,0.2495071047057295f),Quaternion.Euler(0,-43.092261001363966f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.10046013387821968f);
skate1.transform.position = new Vector3(17.878093627979645f,0f,-0.2495071047057295f);
skate1.transform.rotation = Quaternion.Euler(0,47.623936242549554f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(17.878093627979645f,0f,-0.2495071047057295f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.13756864978448835f);
moveline1 = Instantiate(moveline,new Vector3(17.878093627979645f,0f,-0.2495071047057295f),Quaternion.Euler(0,-136.90773899863603f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.10046013387821968f);
}
}
public class frame356 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(15.434496867732054f,0f,0.19841122853814297f);
skate0.transform.rotation = Quaternion.Euler(0,131.5166270647542f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(15.434496867732054f,0f,0.19841122853814297f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.148393450816716f);
moveline0 = Instantiate(moveline,new Vector3(15.434496867732054f,0f,0.19841122853814297f),Quaternion.Euler(0,42.376063757450446f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(17.93449686773205f,0f,-0.19841122853814297f);
skate1.transform.rotation = Quaternion.Euler(0,48.48337293524579f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(17.93449686773205f,0f,-0.19841122853814297f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.148393450816716f);
moveline1 = Instantiate(moveline,new Vector3(17.93449686773205f,0f,-0.19841122853814297f),Quaternion.Euler(0,137.62393624254955f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame357 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(15.492083745636307f,0f,0.14836853363614427f);
skate0.transform.rotation = Quaternion.Euler(0,130.51395092327527f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(15.492083745636307f,0f,0.14836853363614427f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.15898189015948141f);
moveline0 = Instantiate(moveline,new Vector3(15.492083745636307f,0f,0.14836853363614427f),Quaternion.Euler(0,41.51662706475421f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(17.992083745636304f,0f,-0.14836853363614427f);
skate1.transform.rotation = Quaternion.Euler(0,49.486049076724726f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(17.992083745636304f,0f,-0.14836853363614427f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.15898189015948141f);
moveline1 = Instantiate(moveline,new Vector3(17.992083745636304f,0f,-0.14836853363614427f),Quaternion.Euler(0,138.4833729352458f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame358 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(15.549521278214828f,0f,0.09819822287298743f);
skate0.transform.rotation = Quaternion.Euler(0,129.36803533301364f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(15.549521278214828f,0f,0.09819822287298743f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.16933872508398254f);
moveline0 = Instantiate(moveline,new Vector3(15.549521278214828f,0f,0.09819822287298743f),Quaternion.Euler(0,-40.513950923275274f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.1287393947664127f);
skate1.transform.position = new Vector3(18.049521278214822f,0f,-0.09819822287298743f);
skate1.transform.rotation = Quaternion.Euler(0,50.63196466698637f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(18.049521278214822f,0f,-0.09819822287298743f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.16933872508398254f);
moveline1 = Instantiate(moveline,new Vector3(18.049521278214822f,0f,-0.09819822287298743f),Quaternion.Euler(0,-139.4860490767247f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.1287393947664127f);
}
}
public class frame359 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(15.608091488141797f,0f,0.049087511170277924f);
skate0.transform.rotation = Quaternion.Euler(0,128.0788802939693f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(15.608091488141797f,0f,0.049087511170277924f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.17971208834597574f);
moveline0 = Instantiate(moveline,new Vector3(15.608091488141797f,0f,0.049087511170277924f),Quaternion.Euler(0,39.36803533301364f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(18.108091488141792f,0f,-0.049087511170277924f);
skate1.transform.rotation = Quaternion.Euler(0,51.92111970603072f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(18.108091488141792f,0f,-0.049087511170277924f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.17971208834597574f);
moveline1 = Instantiate(moveline,new Vector3(18.108091488141792f,0f,-0.049087511170277924f),Quaternion.Euler(0,140.63196466698636f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame360 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(15.667763029787272f,0f,0.0010434109087613039f);
skate0.transform.rotation = Quaternion.Euler(0,126.64648580614221f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(15.667763029787272f,0f,0.0010434109087613039f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.18986000603806152f);
moveline0 = Instantiate(moveline,new Vector3(15.667763029787272f,0f,0.0010434109087613039f),Quaternion.Euler(0,38.078880293969284f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(18.167763029787267f,0f,-0.0010434109087613039f);
skate1.transform.rotation = Quaternion.Euler(0,53.353514193857784f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(18.167763029787267f,0f,-0.0010434109087613039f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.18986000603806152f);
moveline1 = Instantiate(moveline,new Vector3(18.167763029787267f,0f,-0.0010434109087613039f),Quaternion.Euler(0,141.9211197060307f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame361 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(15.728500421484284f,0f,-0.04592470899257731f);
skate0.transform.rotation = Quaternion.Euler(0,125.07085186953245f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(15.728500421484284f,0f,-0.04592470899257731f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.19978447396444046f);
moveline0 = Instantiate(moveline,new Vector3(15.728500421484284f,0f,-0.04592470899257731f),Quaternion.Euler(0,36.646485806142216f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(18.22850042148428f,0f,0.04592470899257731f);
skate1.transform.rotation = Quaternion.Euler(0,54.929148130467546f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(18.22850042148428f,0f,0.04592470899257731f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.19978447396444046f);
moveline1 = Instantiate(moveline,new Vector3(18.22850042148428f,0f,0.04592470899257731f),Quaternion.Euler(0,143.3535141938578f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame362 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(15.790263864894966f,0f,-0.09180540828587194f);
skate0.transform.rotation = Quaternion.Euler(0,123.35197848413998f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(15.790263864894966f,0f,-0.09180540828587194f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.2094865939454807f);
moveline0 = Instantiate(moveline,new Vector3(15.790263864894966f,0f,-0.09180540828587194f),Quaternion.Euler(0,35.07085186953246f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(18.29026386489496f,0f,0.09180540828587194f);
skate1.transform.rotation = Quaternion.Euler(0,56.648021515860016f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(18.29026386489496f,0f,0.09180540828587194f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.2094865939454807f);
moveline1 = Instantiate(moveline,new Vector3(18.29026386489496f,0f,0.09180540828587194f),Quaternion.Euler(0,144.92914813046752f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame363 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(15.853009059792798f,0f,-0.13658549634306238f);
skate0.transform.rotation = Quaternion.Euler(0,121.48986564996481f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(15.853009059792798f,0f,-0.13658549634306238f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.2189666541485092f);
moveline0 = Instantiate(moveline,new Vector3(15.853009059792798f,0f,-0.13658549634306238f),Quaternion.Euler(0,33.351978484139984f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(18.353009059792793f,0f,0.13658549634306238f);
skate1.transform.rotation = Quaternion.Euler(0,58.51013435003519f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(18.353009059792793f,0f,0.13658549634306238f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.2189666541485092f);
moveline1 = Instantiate(moveline,new Vector3(18.353009059792793f,0f,0.13658549634306238f),Quaternion.Euler(0,146.64802151586002f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame364 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(15.916687018518216f,0f,-0.18025039090827044f);
skate0.transform.rotation = Quaternion.Euler(0,119.48451336700693f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(15.916687018518216f,0f,-0.18025039090827044f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.2282242138896573f);
moveline0 = Instantiate(moveline,new Vector3(15.916687018518216f,0f,-0.18025039090827044f),Quaternion.Euler(0,31.489865649964813f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(18.41668701851821f,0f,0.18025039090827044f);
skate1.transform.rotation = Quaternion.Euler(0,60.515486632993074f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(18.41668701851821f,0f,0.18025039090827044f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.2282242138896573f);
moveline1 = Instantiate(moveline,new Vector3(18.41668701851821f,0f,0.18025039090827044f),Quaternion.Euler(0,148.51013435003517f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame365 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(15.981243884906663f,0f,-0.22278451660117182f);
skate0.transform.rotation = Quaternion.Euler(0,117.33592163526635f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(15.981243884906663f,0f,-0.22278451660117182f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.23725819416445842f);
moveline0 = Instantiate(moveline,new Vector3(15.981243884906663f,0f,-0.22278451660117182f),Quaternion.Euler(0,29.484513367006947f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(18.481243884906657f,0f,0.22278451660117182f);
skate1.transform.rotation = Quaternion.Euler(0,62.66407836473366f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(18.481243884906657f,0f,0.22278451660117182f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.23725819416445842f);
moveline1 = Instantiate(moveline,new Vector3(18.481243884906657f,0f,0.22278451660117182f),Quaternion.Euler(0,150.51548663299306f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame366 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(16.04662076305154f,0f,-0.264171744915101f);
skate0.transform.rotation = Quaternion.Euler(0,115.04409045474304f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(16.04662076305154f,0f,-0.264171744915101f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.2460669750973495f);
moveline0 = Instantiate(moveline,new Vector3(16.04662076305154f,0f,-0.264171744915101f),Quaternion.Euler(0,27.335921635266338f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(18.546620763051532f,0f,0.264171744915101f);
skate1.transform.rotation = Quaternion.Euler(0,64.95590954525696f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(18.546620763051532f,0f,0.264171744915101f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.2460669750973495f);
moveline1 = Instantiate(moveline,new Vector3(18.546620763051532f,0f,0.264171744915101f),Quaternion.Euler(0,152.66407836473365f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame367 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(16.112753561842442f,0f,-0.30439587715298755f);
skate0.transform.rotation = Quaternion.Euler(0,112.60901982543704f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(16.112753561842442f,0f,-0.30439587715298755f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.254648501414423f);
moveline0 = Instantiate(moveline,new Vector3(16.112753561842442f,0f,-0.30439587715298755f),Quaternion.Euler(0,25.044090454743042f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(18.612753561842435f,0f,0.30439587715298755f);
skate1.transform.rotation = Quaternion.Euler(0,67.39098017456296f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(18.612753561842435f,0f,0.30439587715298755f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.254648501414423f);
moveline1 = Instantiate(moveline,new Vector3(18.612753561842435f,0f,0.30439587715298755f),Quaternion.Euler(0,154.95590954525696f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame368 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(16.179572861802754f,0f,-0.34344117133587837f);
skate0.transform.rotation = Quaternion.Euler(0,110.03070974734834f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(16.179572861802754f,0f,-0.34344117133587837f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.26300039693407146f);
moveline0 = Instantiate(moveline,new Vector3(16.179572861802754f,0f,-0.34344117133587837f),Quaternion.Euler(0,22.609019825437045f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(18.679572861802747f,0f,0.34344117133587837f);
skate1.transform.rotation = Quaternion.Euler(0,69.96929025265166f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(18.679572861802747f,0f,0.34344117133587837f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.26300039693407146f);
moveline1 = Instantiate(moveline,new Vector3(18.679572861802747f,0f,0.34344117133587837f),Quaternion.Euler(0,157.39098017456297f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame369 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(16.24700381132816f,0f,-0.3812929135923277f);
skate0.transform.rotation = Quaternion.Euler(0,107.30916022047693f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(16.24700381132816f,0f,-0.3812929135923277f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.2711200889312195f);
moveline0 = Instantiate(moveline,new Vector3(16.24700381132816f,0f,-0.3812929135923277f),Quaternion.Euler(0,20.03070974734834f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(18.747003811328153f,0f,0.3812929135923277f);
skate1.transform.rotation = Quaternion.Euler(0,72.69083977952307f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(18.747003811328153f,0f,0.3812929135923277f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.2711200889312195f);
moveline1 = Instantiate(moveline,new Vector3(18.747003811328153f,0f,0.3812929135923277f),Quaternion.Euler(0,159.96929025265166f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame370 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(16.314966059985032f,0f,-0.4179380338824634f);
skate0.transform.rotation = Quaternion.Euler(0,104.4443712448228f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(16.314966059985032f,0f,-0.4179380338824634f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.27900494305778034f);
moveline0 = Instantiate(moveline,new Vector3(16.314966059985032f,0f,-0.4179380338824634f),Quaternion.Euler(0,17.309160220476926f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
skate1.transform.position = new Vector3(18.814966059985025f,0f,0.4179380338824634f);
skate1.transform.rotation = Quaternion.Euler(0,75.5556287551772f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(18.814966059985025f,0f,0.4179380338824634f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.27900494305778034f);
moveline1 = Instantiate(moveline,new Vector3(18.814966059985025f,0f,0.4179380338824634f),Quaternion.Euler(0,162.69083977952306f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
}
}
public class frame371 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(16.383373737047027f,0f,-0.45336576511917775f);
skate0.transform.rotation = Quaternion.Euler(0,101.43634282038599f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(16.383373737047027f,0f,-0.45336576511917775f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.2866524092906629f);
moveline0 = Instantiate(moveline,new Vector3(16.383373737047027f,0f,-0.45336576511917775f),Quaternion.Euler(0,14.444371244822804f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(18.88337373704702f,0f,0.45336576511917775f);
skate1.transform.rotation = Quaternion.Euler(0,78.56365717961401f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(18.88337373704702f,0f,0.45336576511917775f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.2866524092906629f);
moveline1 = Instantiate(moveline,new Vector3(18.88337373704702f,0f,0.45336576511917775f),Quaternion.Euler(0,165.5556287551772f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame372 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(16.45213548390977f,0f,-0.48756834381324576f);
skate0.transform.rotation = Quaternion.Euler(0,98.28507494716645f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(16.45213548390977f,0f,-0.48756834381324576f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.294060179125952f);
moveline0 = Instantiate(moveline,new Vector3(16.45213548390977f,0f,-0.48756834381324576f),Quaternion.Euler(0,11.436342820385974f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(18.952135483909764f,0f,0.48756834381324576f);
skate1.transform.rotation = Quaternion.Euler(0,81.71492505283355f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(18.952135483909764f,0f,0.48756834381324576f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.294060179125952f);
moveline1 = Instantiate(moveline,new Vector3(18.952135483909764f,0f,0.48756834381324576f),Quaternion.Euler(0,168.56365717961404f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame373 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(16.52115454940329f,0f,-0.520541749283938f);
skate0.transform.rotation = Quaternion.Euler(0,94.99056762516422f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(16.52115454940329f,0f,-0.520541749283938f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.3012263539419573f);
moveline0 = Instantiate(moveline,new Vector3(16.52115454940329f,0f,-0.520541749283938f),Quaternion.Euler(0,8.28507494716645f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(19.02115454940328f,0f,0.520541749283938f);
skate1.transform.rotation = Quaternion.Euler(0,85.00943237483578f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(19.02115454940328f,0f,0.520541749283938f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.3012263539419573f);
moveline1 = Instantiate(moveline,new Vector3(19.02115454940328f,0f,0.520541749283938f),Quaternion.Euler(0,171.71492505283356f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame374 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(16.590328957293274f,0f,-0.5522864772393107f);
skate0.transform.rotation = Quaternion.Euler(0,91.55282085437928f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(16.590328957293274f,0f,-0.5522864772393107f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.3081496241144739f);
moveline0 = Instantiate(moveline,new Vector3(16.590328957293274f,0f,-0.5522864772393107f),Quaternion.Euler(0,4.990567625164218f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(19.090328957293266f,0f,0.5522864772393107f);
skate1.transform.rotation = Quaternion.Euler(0,88.44717914562072f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(19.090328957293266f,0f,0.5522864772393107f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.3081496241144739f);
moveline1 = Instantiate(moveline,new Vector3(19.090328957293266f,0f,0.5522864772393107f),Quaternion.Euler(0,175.0094323748358f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame375 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(16.659551755395697f,0f,-0.582808342141793f);
skate0.transform.rotation = Quaternion.Euler(0,87.97183463481163f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(16.659551755395697f,0f,-0.582808342141793f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.31482945808656054f);
moveline0 = Instantiate(moveline,new Vector3(16.659551755395697f,0f,-0.582808342141793f),Quaternion.Euler(0,1.5528208543792772f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(19.15955175539569f,0f,0.582808342141793f);
skate1.transform.rotation = Quaternion.Euler(0,92.02816536518837f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(19.15955175539569f,0f,0.582808342141793f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.31482945808656054f);
moveline1 = Instantiate(moveline,new Vector3(19.15955175539569f,0f,0.582808342141793f),Quaternion.Euler(0,178.44717914562074f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame376 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(16.728711355692106f,0f,-0.6092621583831054f);
skate0.transform.rotation = Quaternion.Euler(0,84.53408786402669f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(16.728711355692106f,0f,-0.6092621583831054f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2787336998236736f);
moveline0 = Instantiate(moveline,new Vector3(16.728711355692106f,0f,-0.6092621583831054f),Quaternion.Euler(0,-2.0281653651883573f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(19.2287113556921f,0f,0.6092621583831054f);
skate1.transform.rotation = Quaternion.Euler(0,95.46591213597331f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(19.2287113556921f,0f,0.6092621583831054f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2787336998236736f);
moveline1 = Instantiate(moveline,new Vector3(19.2287113556921f,0f,0.6092621583831054f),Quaternion.Euler(0,-177.97183463481161f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame377 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(16.797700860400763f,0f,-0.6316649106770941f);
skate0.transform.rotation = Quaternion.Euler(0,81.23958054202446f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(16.797700860400763f,0f,-0.6316649106770941f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2731427653071863f);
moveline0 = Instantiate(moveline,new Vector3(16.797700860400763f,0f,-0.6316649106770941f),Quaternion.Euler(0,-5.465912135973298f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
skate1.transform.position = new Vector3(19.297700860400756f,0f,0.6316649106770941f);
skate1.transform.rotation = Quaternion.Euler(0,98.76041945797554f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(19.297700860400756f,0f,0.6316649106770941f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2731427653071863f);
moveline1 = Instantiate(moveline,new Vector3(19.297700860400756f,0f,0.6316649106770941f),Quaternion.Euler(0,-174.53408786402673f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
}
}
public class frame378 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(16.866418395250463f,0f,-0.6500377831711683f);
skate0.transform.rotation = Quaternion.Euler(0,78.08831266880492f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(16.866418395250463f,0f,-0.6500377831711683f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2683988580502694f);
moveline0 = Instantiate(moveline,new Vector3(16.866418395250463f,0f,-0.6500377831711683f),Quaternion.Euler(0,-8.76041945797553f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(19.366418395250456f,0f,0.6500377831711683f);
skate1.transform.rotation = Quaternion.Euler(0,101.91168733119508f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(19.366418395250456f,0f,0.6500377831711683f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2683988580502694f);
moveline1 = Instantiate(moveline,new Vector3(19.366418395250456f,0f,0.6500377831711683f),Quaternion.Euler(0,-171.2395805420245f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame379 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(16.93476735192208f,0f,-0.6644053544373782f);
skate0.transform.rotation = Quaternion.Euler(0,75.0802842443681f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(16.93476735192208f,0f,-0.6644053544373782f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2645017848859639f);
moveline0 = Instantiate(moveline,new Vector3(16.93476735192208f,0f,-0.6644053544373782f),Quaternion.Euler(0,-11.911687331195083f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(19.434767351922073f,0f,0.6644053544373782f);
skate1.transform.rotation = Quaternion.Euler(0,104.9197157556319f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(19.434767351922073f,0f,0.6644053544373782f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2645017848859639f);
moveline1 = Instantiate(moveline,new Vector3(19.434767351922073f,0f,0.6644053544373782f),Quaternion.Euler(0,-168.08831266880492f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame380 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(17.002656549106874f,0f,-0.6747948228512278f);
skate0.transform.rotation = Quaternion.Euler(0,72.21549526871398f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(17.002656549106874f,0f,-0.6747948228512278f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2614500558533925f);
moveline0 = Instantiate(moveline,new Vector3(17.002656549106874f,0f,-0.6747948228512278f),Quaternion.Euler(0,-14.919715755631884f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(19.502656549106867f,0f,0.6747948228512278f);
skate1.transform.rotation = Quaternion.Euler(0,107.78450473128602f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(19.502656549106867f,0f,0.6747948228512278f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2614500558533925f);
moveline1 = Instantiate(moveline,new Vector3(19.502656549106867f,0f,0.6747948228512278f),Quaternion.Euler(0,-165.08028424436807f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame381 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(17.07000032165484f,0f,-0.6812352681242916f);
skate0.transform.rotation = Quaternion.Euler(0,69.49394574184257f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(17.07000032165484f,0f,-0.6812352681242916f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2592409276229375f);
moveline0 = Instantiate(moveline,new Vector3(17.07000032165484f,0f,-0.6812352681242916f),Quaternion.Euler(0,-17.78450473128602f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(19.570000321654835f,0f,0.6812352681242916f);
skate1.transform.rotation = Quaternion.Euler(0,110.50605425815743f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(19.570000321654835f,0f,0.6812352681242916f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2592409276229375f);
moveline1 = Instantiate(moveline,new Vector3(19.570000321654835f,0f,0.6812352681242916f),Quaternion.Euler(0,-162.215495268714f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame382 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(17.13671854714138f,0f,-0.6837569533054235f);
skate0.transform.rotation = Quaternion.Euler(0,66.91563566375386f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(17.13671854714138f,0f,-0.6837569533054235f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.257870472734351f);
moveline0 = Instantiate(moveline,new Vector3(17.13671854714138f,0f,-0.6837569533054235f),Quaternion.Euler(0,-20.506054258157434f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(19.636718547141374f,0f,0.6837569533054235f);
skate1.transform.rotation = Quaternion.Euler(0,113.08436433624614f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(19.636718547141374f,0f,0.6837569533054235f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.257870472734351f);
moveline1 = Instantiate(moveline,new Vector3(19.636718547141374f,0f,0.6837569533054235f),Quaternion.Euler(0,-159.49394574184254f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame383 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(17.202736618898633f,0f,-0.6823906702683467f);
skate0.transform.rotation = Quaternion.Euler(0,64.48056503444786f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(17.202736618898633f,0f,-0.6823906702683467f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2573336727547448f);
moveline0 = Instantiate(moveline,new Vector3(17.202736618898633f,0f,-0.6823906702683467f),Quaternion.Euler(0,-23.084364336246125f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(19.702736618898626f,0f,0.6823906702683467f);
skate1.transform.rotation = Quaternion.Euler(0,115.51943496555214f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(19.702736618898626f,0f,0.6823906702683467f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2573336727547448f);
moveline1 = Instantiate(moveline,new Vector3(19.702736618898626f,0f,0.6823906702683467f),Quaternion.Euler(0,-156.91563566375385f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame384 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(17.26798537416892f,0f,-0.6771671305625572f);
skate0.transform.rotation = Quaternion.Euler(0,62.18873385392457f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(17.26798537416892f,0f,-0.6771671305625572f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2576245331977403f);
moveline0 = Instantiate(moveline,new Vector3(17.26798537416892f,0f,-0.6771671305625572f),Quaternion.Euler(0,-25.51943496555215f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(19.767985374168912f,0f,0.6771671305625572f);
skate1.transform.rotation = Quaternion.Euler(0,117.81126614607544f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(19.767985374168912f,0f,0.6771671305625572f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2576245331977403f);
moveline1 = Instantiate(moveline,new Vector3(19.767985374168912f,0f,0.6771671305625572f),Quaternion.Euler(0,-154.48056503444784f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame385 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(17.33240098556837f,0f,-0.6681164025179289f);
skate0.transform.rotation = Quaternion.Euler(0,60.04014212218398f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(17.33240098556837f,0f,-0.6681164025179289f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2587362178661734f);
moveline0 = Instantiate(moveline,new Vector3(17.33240098556837f,0f,-0.6681164025179289f),Quaternion.Euler(0,-27.81126614607541f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(19.832400985568363f,0f,0.6681164025179289f);
skate1.transform.rotation = Quaternion.Euler(0,119.95985787781602f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(19.832400985568363f,0f,0.6681164025179289f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2587362178661734f);
moveline1 = Instantiate(moveline,new Vector3(19.832400985568363f,0f,0.6681164025179289f),Quaternion.Euler(0,-152.1887338539246f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame386 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(17.395924823522517f,0f,-0.6552673946563283f);
skate0.transform.rotation = Quaternion.Euler(0,58.03478983922609f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(17.395924823522517f,0f,-0.6552673946563283f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2606612001957895f);
moveline0 = Instantiate(moveline,new Vector3(17.395924823522517f,0f,-0.6552673946563283f),Quaternion.Euler(0,-29.959857877816034f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(19.89592482352251f,0f,0.6552673946563283f);
skate1.transform.rotation = Quaternion.Euler(0,121.9652101607739f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(19.89592482352251f,0f,0.6552673946563283f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2606612001957895f);
moveline1 = Instantiate(moveline,new Vector3(19.89592482352251f,0f,0.6552673946563283f),Quaternion.Euler(0,-150.04014212218397f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame387 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(17.45850329677289f,0f,-0.6386473847688212f);
skate0.transform.rotation = Quaternion.Euler(0,56.17267700505092f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(17.45850329677289f,0f,-0.6386473847688212f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2633914291887183f);
moveline0 = Instantiate(moveline,new Vector3(17.45850329677289f,0f,-0.6386473847688212f),Quaternion.Euler(0,-31.965210160773864f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
skate1.transform.position = new Vector3(19.958503296772882f,0f,0.6386473847688212f);
skate1.transform.rotation = Quaternion.Euler(0,123.82732299494907f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(19.958503296772882f,0f,0.6386473847688212f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2633914291887183f);
moveline1 = Instantiate(moveline,new Vector3(19.958503296772882f,0f,0.6386473847688212f),Quaternion.Euler(0,-148.03478983922614f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
}
}
public class frame388 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(17.520087677471537f,0f,-0.6182815934558211f);
skate0.transform.rotation = Quaternion.Euler(0,54.45380361965845f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(17.520087677471537f,0f,-0.6182815934558211f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2669185076313594f);
moveline0 = Instantiate(moveline,new Vector3(17.520087677471537f,0f,-0.6182815934558211f),Quaternion.Euler(0,-33.827322994949085f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(20.02008767747153f,0f,0.6182815934558211f);
skate1.transform.rotation = Quaternion.Euler(0,125.54619638034154f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(20.02008767747153f,0f,0.6182815934558211f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2669185076313594f);
moveline1 = Instantiate(moveline,new Vector3(20.02008767747153f,0f,0.6182815934558211f),Quaternion.Euler(0,-146.17267700505093f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame389 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(17.58063391679325f,0f,-0.5941928004897713f);
skate0.transform.rotation = Quaternion.Euler(0,52.87816968304869f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(17.58063391679325f,0f,-0.5941928004897713f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2712338804865189f);
moveline0 = Instantiate(moveline,new Vector3(17.58063391679325f,0f,-0.5941928004897713f),Quaternion.Euler(0,-35.54619638034154f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
skate1.transform.position = new Vector3(20.080633916793243f,0f,0.5941928004897713f);
skate1.transform.rotation = Quaternion.Euler(0,127.1218303169513f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(20.080633916793243f,0f,0.5941928004897713f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2712338804865189f);
moveline1 = Instantiate(moveline,new Vector3(20.080633916793243f,0f,0.5941928004897713f),Quaternion.Euler(0,-144.4538036196585f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
}
}
public class frame390 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(17.640102456414727f,0f,-0.5664010020348959f);
skate0.transform.rotation = Quaternion.Euler(0,51.44577519522163f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(17.640102456414727f,0f,-0.5664010020348959f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2763290316267528f);
moveline0 = Instantiate(moveline,new Vector3(17.640102456414727f,0f,-0.5664010020348959f),Quaternion.Euler(0,-37.12183031695132f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(20.14010245641472f,0f,0.5664010020348959f);
skate1.transform.rotation = Quaternion.Euler(0,128.55422480477836f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(20.14010245641472f,0f,0.5664010020348959f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2763290316267528f);
moveline1 = Instantiate(moveline,new Vector3(20.14010245641472f,0f,0.5664010020348959f),Quaternion.Euler(0,-142.87816968304867f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame391 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(17.698458040644812f,0f,-0.5349231065350665f);
skate0.transform.rotation = Quaternion.Euler(0,50.15662015617728f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(17.698458040644812f,0f,-0.5349231065350665f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2821956874262774f);
moveline0 = Instantiate(moveline,new Vector3(17.698458040644812f,0f,-0.5349231065350665f),Quaternion.Euler(0,-38.554224804778386f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(20.198458040644805f,0f,0.5349231065350665f);
skate1.transform.rotation = Quaternion.Euler(0,129.84337984382273f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(20.198458040644805f,0f,0.5349231065350665f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2821956874262774f);
moveline1 = Instantiate(moveline,new Vector3(20.198458040644805f,0f,0.5349231065350665f),Quaternion.Euler(0,-141.44577519522164f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame392 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(17.75566953344698f,0f,-0.4997726669477034f);
skate0.transform.rotation = Quaternion.Euler(0,49.01070456591563f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(17.75566953344698f,0f,-0.4997726669477034f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2888260261437048f);
moveline0 = Instantiate(moveline,new Vector3(17.75566953344698f,0f,-0.4997726669477034f),Quaternion.Euler(0,-39.8433798438227f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(20.255669533446973f,0f,0.4997726669477034f);
skate1.transform.rotation = Quaternion.Euler(0,130.98929543408437f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(20.255669533446973f,0f,0.4997726669477034f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2888260261437048f);
moveline1 = Instantiate(moveline,new Vector3(20.255669533446973f,0f,0.4997726669477034f),Quaternion.Euler(0,-140.1566201561773f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame393 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(17.811709744079128f,0f,-0.4609596469478297f);
skate0.transform.rotation = Quaternion.Euler(0,48.008028424436695f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(17.811709744079128f,0f,-0.4609596469478297f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.2962128924995413f);
moveline0 = Instantiate(moveline,new Vector3(17.811709744079128f,0f,-0.4609596469478297f),Quaternion.Euler(0,-40.98929543408437f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(20.31170974407912f,0f,0.4609596469478297f);
skate1.transform.rotation = Quaternion.Euler(0,131.9919715755633f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(20.31170974407912f,0f,0.4609596469478297f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.2962128924995413f);
moveline1 = Instantiate(moveline,new Vector3(20.31170974407912f,0f,0.4609596469478297f),Quaternion.Euler(0,-139.01070456591563f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame394 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(17.86655526458891f,0f,-0.41849021874122405f);
skate0.transform.rotation = Quaternion.Euler(0,47.14859173174046f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(17.86655526458891f,0f,-0.41849021874122405f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3043500173750346f);
moveline0 = Instantiate(moveline,new Vector3(17.86655526458891f,0f,-0.41849021874122405f),Quaternion.Euler(0,-41.991971575563326f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(20.366555264588904f,0f,0.41849021874122405f);
skate1.transform.rotation = Quaternion.Euler(0,132.85140826825955f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(20.366555264588904f,0f,0.41849021874122405f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3043500173750346f);
moveline1 = Instantiate(moveline,new Vector3(20.366555264588904f,0f,0.41849021874122405f),Quaternion.Euler(0,-138.00802842443667f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame395 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(17.92018632194679f,0f,-0.37236659019881896f);
skate0.transform.rotation = Quaternion.Euler(0,46.43239448782693f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(17.92018632194679f,0f,-0.37236659019881896f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.313232243129814f);
moveline0 = Instantiate(moveline,new Vector3(17.92018632194679f,0f,-0.37236659019881896f),Quaternion.Euler(0,-42.85140826825955f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(20.420186321946783f,0f,0.37236659019881896f);
skate1.transform.rotation = Quaternion.Euler(0,133.56760551217306f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(20.420186321946783f,0f,0.37236659019881896f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.313232243129814f);
moveline1 = Instantiate(moveline,new Vector3(20.420186321946783f,0f,0.37236659019881896f),Quaternion.Euler(0,-137.14859173174045f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame396 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(17.97258664717313f,0f,-0.3225868591463331f);
skate0.transform.rotation = Quaternion.Euler(0,45.85943669269611f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(17.97258664717313f,0f,-0.3225868591463331f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.322855755655858f);
moveline0 = Instantiate(moveline,new Vector3(17.97258664717313f,0f,-0.3225868591463331f),Quaternion.Euler(0,-43.56760551217306f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(20.472586647173124f,0f,0.3225868591463331f);
skate1.transform.rotation = Quaternion.Euler(0,134.1405633073039f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(20.472586647173124f,0f,0.3225868591463331f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.322855755655858f);
moveline1 = Instantiate(moveline,new Vector3(20.472586647173124f,0f,0.3225868591463331f),Quaternion.Euler(0,-136.4323944878269f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame397 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(18.023743363418774f,0f,-0.26914489280438225f);
skate0.transform.rotation = Quaternion.Euler(0,45.429718346348f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(18.023743363418774f,0f,-0.26914489280438225f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3332183249604834f);
moveline0 = Instantiate(moveline,new Vector3(18.023743363418774f,0f,-0.26914489280438225f),Quaternion.Euler(0,-44.14056330730389f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(20.523743363418767f,0f,0.26914489280438225f);
skate1.transform.rotation = Quaternion.Euler(0,134.570281653652f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(20.523743363418767f,0f,0.26914489280438225f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3332183249604834f);
moveline1 = Instantiate(moveline,new Vector3(20.523743363418767f,0f,0.26914489280438225f),Quaternion.Euler(0,-135.8594366926961f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame398 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(18.076153264740775f,0f,-0.2145744810842694f);
skate0.transform.rotation = Quaternion.Euler(0,45.14323944878258f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(18.076153264740775f,0f,-0.2145744810842694f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3443195568128412f);
moveline0 = Instantiate(moveline,new Vector3(18.076153264740775f,0f,-0.2145744810842694f),Quaternion.Euler(0,135.429718346348f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(20.576153264740768f,0f,0.2145744810842694f);
skate1.transform.rotation = Quaternion.Euler(0,134.8567605512174f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(20.576153264740768f,0f,0.2145744810842694f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3443195568128412f);
moveline1 = Instantiate(moveline,new Vector3(20.576153264740768f,0f,0.2145744810842694f),Quaternion.Euler(0,44.570281653652f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame399 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(18.129822696074147f,0f,-0.15884913766761882f);
skate0.transform.rotation = Quaternion.Euler(0,44.99999999999987f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(18.129822696074147f,0f,-0.15884913766761882f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3556340866516905f);
moveline0 = Instantiate(moveline,new Vector3(18.129822696074147f,0f,-0.15884913766761882f),Quaternion.Euler(0,135.1432394487826f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(20.62982269607414f,0f,0.15884913766761882f);
skate1.transform.rotation = Quaternion.Euler(0,135.0000000000001f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(20.62982269607414f,0f,0.15884913766761882f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3556340866516905f);
moveline1 = Instantiate(moveline,new Vector3(20.62982269607414f,0f,0.15884913766761882f),Quaternion.Euler(0,44.85676055121742f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame400 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(18.18475481808821f,0f,-0.10194510888484475f);
skate0.transform.rotation = Quaternion.Euler(0,44.99999999999987f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(18.18475481808821f,0f,-0.10194510888484475f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3671705862157002f);
moveline0 = Instantiate(moveline,new Vector3(18.18475481808821f,0f,-0.10194510888484475f),Quaternion.Euler(0,134.9999999999999f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(20.6847548180882f,0f,0.10194510888484475f);
skate1.transform.rotation = Quaternion.Euler(0,135.0000000000001f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(20.6847548180882f,0f,0.10194510888484475f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3671705862157002f);
moveline1 = Instantiate(moveline,new Vector3(20.6847548180882f,0f,0.10194510888484475f),Quaternion.Euler(0,45.00000000000012f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame401 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(18.24094963078296f,0f,-0.0459842392853757f);
skate0.transform.rotation = Quaternion.Euler(0,45.14323944878257f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(18.24094963078296f,0f,-0.0459842392853757f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.178937638535731f);
moveline0 = Instantiate(moveline,new Vector3(18.24094963078296f,0f,-0.0459842392853757f),Quaternion.Euler(0,134.9999999999999f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(20.740949630782954f,0f,0.0459842392853757f);
skate1.transform.rotation = Quaternion.Euler(0,134.85676055121743f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(20.740949630782954f,0f,0.0459842392853757f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.178937638535731f);
moveline1 = Instantiate(moveline,new Vector3(20.740949630782954f,0f,0.0459842392853757f),Quaternion.Euler(0,45.00000000000012f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame402 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(18.296974355328956f,0f,0.010145870141144604f);
skate0.transform.rotation = Quaternion.Euler(0,45.42971834634799f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(18.296974355328956f,0f,0.010145870141144604f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.19050110786797642f);
moveline0 = Instantiate(moveline,new Vector3(18.296974355328956f,0f,0.010145870141144604f),Quaternion.Euler(0,-135.14323944878257f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.1350409654574606f);
skate1.transform.position = new Vector3(20.79697435532895f,0f,-0.010145870141144604f);
skate1.transform.rotation = Quaternion.Euler(0,134.57028165365202f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(20.79697435532895f,0f,-0.010145870141144604f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.19050110786797642f);
moveline1 = Instantiate(moveline,new Vector3(20.79697435532895f,0f,-0.010145870141144604f),Quaternion.Euler(0,-44.856760551217434f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.1350409654574606f);
}
}
public class frame403 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(18.352818657561393f,0f,0.06645371564293875f);
skate0.transform.rotation = Quaternion.Euler(0,45.8594366926961f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(18.352818657561393f,0f,0.06645371564293875f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.20209572652704325f);
moveline0 = Instantiate(moveline,new Vector3(18.352818657561393f,0f,0.06645371564293875f),Quaternion.Euler(0,-135.42971834634798f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.14397100393299705f);
skate1.transform.position = new Vector3(20.852818657561386f,0f,-0.06645371564293875f);
skate1.transform.rotation = Quaternion.Euler(0,134.1405633073039f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(20.852818657561386f,0f,-0.06645371564293875f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.20209572652704325f);
moveline1 = Instantiate(moveline,new Vector3(20.852818657561386f,0f,-0.06645371564293875f),Quaternion.Euler(0,-44.57028165365202f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.14397100393299705f);
}
}
public class frame404 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(18.409906568774527f,0f,0.12186172985313898f);
skate0.transform.rotation = Quaternion.Euler(0,46.432394487826926f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(18.409906568774527f,0f,0.12186172985313898f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.21372791384730833f);
moveline0 = Instantiate(moveline,new Vector3(18.409906568774527f,0f,0.12186172985313898f),Quaternion.Euler(0,135.85943669269608f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(20.90990656877452f,0f,-0.12186172985313898f);
skate1.transform.rotation = Quaternion.Euler(0,133.5676055121731f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(20.90990656877452f,0f,-0.12186172985313898f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.21372791384730833f);
moveline1 = Instantiate(moveline,new Vector3(20.90990656877452f,0f,-0.12186172985313898f),Quaternion.Euler(0,44.14056330730391f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame405 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(18.4682252121192f,0f,0.17637799045443336f);
skate0.transform.rotation = Quaternion.Euler(0,47.14859173174045f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(18.4682252121192f,0f,0.17637799045443336f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.22517962900210975f);
moveline0 = Instantiate(moveline,new Vector3(18.4682252121192f,0f,0.17637799045443336f),Quaternion.Euler(0,136.4323944878269f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(20.968225212119194f,0f,-0.17637799045443336f);
skate1.transform.rotation = Quaternion.Euler(0,132.85140826825955f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(20.968225212119194f,0f,-0.17637799045443336f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.22517962900210975f);
moveline1 = Instantiate(moveline,new Vector3(20.968225212119194f,0f,-0.17637799045443336f),Quaternion.Euler(0,43.56760551217308f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame406 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(18.526333326927016f,0f,0.23108955378243515f);
skate0.transform.rotation = Quaternion.Euler(0,48.00802842443669f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(18.526333326927016f,0f,0.23108955378243515f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.23645668402928782f);
moveline0 = Instantiate(moveline,new Vector3(18.526333326927016f,0f,0.23108955378243515f),Quaternion.Euler(0,-137.14859173174045f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.1733511111710118f);
skate1.transform.position = new Vector3(21.02633332692701f,0f,-0.23108955378243515f);
skate1.transform.rotation = Quaternion.Euler(0,131.9919715755633f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(21.02633332692701f,0f,-0.23108955378243515f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.23645668402928782f);
moveline1 = Instantiate(moveline,new Vector3(21.02633332692701f,0f,-0.23108955378243515f),Quaternion.Euler(0,-42.85140826825955f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.1733511111710118f);
}
}
public class frame407 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(18.585636131857196f,0f,0.28491638416095416f);
skate0.transform.rotation = Quaternion.Euler(0,49.010704565915624f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(18.585636131857196f,0f,0.28491638416095416f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.24778812668452285f);
moveline0 = Instantiate(moveline,new Vector3(18.585636131857196f,0f,0.28491638416095416f),Quaternion.Euler(0,138.00802842443667f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(21.08563613185719f,0f,-0.28491638416095416f);
skate1.transform.rotation = Quaternion.Euler(0,130.98929543408437f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(21.08563613185719f,0f,-0.28491638416095416f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.24778812668452285f);
moveline1 = Instantiate(moveline,new Vector3(21.08563613185719f,0f,-0.28491638416095416f),Quaternion.Euler(0,41.99197157556332f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame408 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(18.646110218957396f,0f,0.3378577183275221f);
skate0.transform.rotation = Quaternion.Euler(0,50.156620156177276f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(18.646110218957396f,0f,0.3378577183275221f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.25895425981377873f);
moveline0 = Instantiate(moveline,new Vector3(18.646110218957396f,0f,0.3378577183275221f),Quaternion.Euler(0,139.0107045659156f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(21.14611021895739f,0f,-0.3378577183275221f);
skate1.transform.rotation = Quaternion.Euler(0,129.84337984382273f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(21.14611021895739f,0f,-0.3378577183275221f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.25895425981377873f);
moveline1 = Instantiate(moveline,new Vector3(21.14611021895739f,0f,-0.3378577183275221f),Quaternion.Euler(0,40.98929543408438f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame409 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(18.70772839748551f,0f,0.38991005159077813f);
skate0.transform.rotation = Quaternion.Euler(0,51.44577519522162f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(18.70772839748551f,0f,0.38991005159077813f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.2699581570205057f);
moveline0 = Instantiate(moveline,new Vector3(18.70772839748551f,0f,0.38991005159077813f),Quaternion.Euler(0,140.15662015617727f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(21.207728397485504f,0f,-0.38991005159077813f);
skate1.transform.rotation = Quaternion.Euler(0,128.55422480477839f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(21.207728397485504f,0f,-0.38991005159077813f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.2699581570205057f);
moveline1 = Instantiate(moveline,new Vector3(21.207728397485504f,0f,-0.38991005159077813f),Quaternion.Euler(0,39.84337984382273f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame410 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(18.77045953140502f,0f,0.4410673550466136f);
skate0.transform.rotation = Quaternion.Euler(0,52.87816968304868f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(18.77045953140502f,0f,0.4410673550466136f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.28080196559241993f);
moveline0 = Instantiate(moveline,new Vector3(18.77045953140502f,0f,0.4410673550466136f),Quaternion.Euler(0,141.44577519522161f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(21.270459531405013f,0f,-0.4410673550466136f);
skate1.transform.rotation = Quaternion.Euler(0,127.12183031695132f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(21.270459531405013f,0f,-0.4410673550466136f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.28080196559241993f);
moveline1 = Instantiate(moveline,new Vector3(21.270459531405013f,0f,-0.4410673550466136f),Quaternion.Euler(0,38.554224804778386f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame411 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(18.834268365024762f,0f,0.491321324429116f);
skate0.transform.rotation = Quaternion.Euler(0,54.453803619658444f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(18.834268365024762f,0f,0.491321324429116f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.29148696104908894f);
moveline0 = Instantiate(moveline,new Vector3(18.834268365024762f,0f,0.491321324429116f),Quaternion.Euler(0,142.87816968304867f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
skate1.transform.position = new Vector3(21.334268365024755f,0f,-0.491321324429116f);
skate1.transform.rotation = Quaternion.Euler(0,125.54619638034156f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(21.334268365024755f,0f,-0.491321324429116f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.29148696104908894f);
moveline1 = Instantiate(moveline,new Vector3(21.334268365024755f,0f,-0.491321324429116f),Quaternion.Euler(0,37.12183031695132f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
}
}
public class frame412 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(18.89911534002144f,0f,0.5406616626688561f);
skate0.transform.rotation = Quaternion.Euler(0,56.172677005050915f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(18.89911534002144f,0f,0.5406616626688561f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.3020136052743917f);
moveline0 = Instantiate(moveline,new Vector3(18.89911534002144f,0f,0.5406616626688561f),Quaternion.Euler(0,144.45380361965846f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(21.39911534002143f,0f,-0.5406616626688561f);
skate1.transform.rotation = Quaternion.Euler(0,123.82732299494909f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(21.39911534002143f,0f,-0.5406616626688561f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.3020136052743917f);
moveline1 = Instantiate(moveline,new Vector3(21.39911534002143f,0f,-0.5406616626688561f),Quaternion.Euler(0,35.546196380341556f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame413 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(18.964956407569844f,0f,0.5890763982637264f);
skate0.transform.rotation = Quaternion.Euler(0,58.03478983922609f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(18.964956407569844f,0f,0.5890763982637264f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.3123816095176671f);
moveline0 = Instantiate(moveline,new Vector3(18.964956407569844f,0f,0.5890763982637264f),Quaternion.Euler(0,146.1726770050509f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(21.464956407569836f,0f,-0.5890763982637264f);
skate1.transform.rotation = Quaternion.Euler(0,121.9652101607739f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(21.464956407569836f,0f,-0.5890763982637264f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.3123816095176671f);
moveline1 = Instantiate(moveline,new Vector3(21.464956407569836f,0f,-0.5890763982637264f),Quaternion.Euler(0,33.827322994949085f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame414 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(19.031742839822023f,0f,0.6365522415340304f);
skate0.transform.rotation = Quaternion.Euler(0,60.04014212218397f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(19.031742839822023f,0f,0.6365522415340304f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.322590003561826f);
moveline0 = Instantiate(moveline,new Vector3(19.031742839822023f,0f,0.6365522415340304f),Quaternion.Euler(0,148.0347898392261f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(21.531742839822016f,0f,-0.6365522415340304f);
skate1.transform.rotation = Quaternion.Euler(0,119.95985787781603f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(21.531742839822016f,0f,-0.6365522415340304f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.322590003561826f);
moveline1 = Instantiate(moveline,new Vector3(21.531742839822016f,0f,-0.6365522415340304f),Quaternion.Euler(0,31.965210160773907f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame415 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(19.099421045519506f,0f,0.6830749807240711f);
skate0.transform.rotation = Quaternion.Euler(0,62.18873385392456f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(19.099421045519506f,0f,0.6830749807240711f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.3326372123612235f);
moveline0 = Instantiate(moveline,new Vector3(19.099421045519506f,0f,0.6830749807240711f),Quaternion.Euler(0,150.04014212218397f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(21.5994210455195f,0f,-0.6830749807240711f);
skate1.transform.rotation = Quaternion.Euler(0,117.81126614607544f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(21.5994210455195f,0f,-0.6830749807240711f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.3326372123612235f);
moveline1 = Instantiate(moveline,new Vector3(21.5994210455195f,0f,-0.6830749807240711f),Quaternion.Euler(0,29.959857877816034f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame416 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(19.167932395087824f,0f,0.7286299197168928f);
skate0.transform.rotation = Quaternion.Euler(0,64.48056503444785f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(19.167932395087824f,0f,0.7286299197168928f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.34252114144089146f);
moveline0 = Instantiate(moveline,new Vector3(19.167932395087824f,0f,0.7286299197168928f),Quaternion.Euler(0,152.1887338539246f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(21.667932395087817f,0f,-0.7286299197168928f);
skate1.transform.rotation = Quaternion.Euler(0,115.51943496555215f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(21.667932395087817f,0f,-0.7286299197168928f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.34252114144089146f);
moveline1 = Instantiate(moveline,new Vector3(21.667932395087817f,0f,-0.7286299197168928f),Quaternion.Euler(0,27.811266146075425f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame417 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(19.237213061143105f,0f,0.7732023588365616f);
skate0.transform.rotation = Quaternion.Euler(0,66.91563566375385f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(19.237213061143105f,0f,0.7732023588365616f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.35223927231570773f);
moveline0 = Instantiate(moveline,new Vector3(19.237213061143105f,0f,0.7732023588365616f),Quaternion.Euler(0,154.48056503444786f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(21.7372130611431f,0f,-0.7732023588365616f);
skate1.transform.rotation = Quaternion.Euler(0,113.08436433624615f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(21.7372130611431f,0f,-0.7732023588365616f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.35223927231570773f);
moveline1 = Instantiate(moveline,new Vector3(21.7372130611431f,0f,-0.7732023588365616f),Quaternion.Euler(0,25.51943496555215f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame418 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(19.307193880927677f,0f,0.8167781198128103f);
skate0.transform.rotation = Quaternion.Euler(0,69.49394574184257f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(19.307193880927677f,0f,0.8167781198128103f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.3617887691269163f);
moveline0 = Instantiate(moveline,new Vector3(19.307193880927677f,0f,0.8167781198128103f),Quaternion.Euler(0,156.91563566375385f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(21.80719388092767f,0f,-0.8167781198128103f);
skate1.transform.rotation = Quaternion.Euler(0,110.50605425815743f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(21.80719388092767f,0f,-0.8167781198128103f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.3617887691269163f);
moveline1 = Instantiate(moveline,new Vector3(21.80719388092767f,0f,-0.8167781198128103f),Quaternion.Euler(0,23.084364336246153f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame419 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(19.377800247773678f,0f,0.8593441154655773f);
skate0.transform.rotation = Quaternion.Euler(0,72.21549526871397f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(19.377800247773678f,0f,0.8593441154655773f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.3711665975977395f);
moveline0 = Instantiate(moveline,new Vector3(19.377800247773678f,0f,0.8593441154655773f),Quaternion.Euler(0,159.49394574184254f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(21.87780024777367f,0f,-0.8593441154655773f);
skate1.transform.rotation = Quaternion.Euler(0,107.78450473128603f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(21.87780024777367f,0f,-0.8593441154655773f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.3711665975977395f);
moveline1 = Instantiate(moveline,new Vector3(21.87780024777367f,0f,-0.8593441154655773f),Quaternion.Euler(0,20.506054258157448f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame420 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(19.4489520392565f,0f,0.9008889640220163f);
skate0.transform.rotation = Quaternion.Euler(0,75.08028424436809f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(19.4489520392565f,0f,0.9008889640220163f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.38036965727347544f);
moveline0 = Instantiate(moveline,new Vector3(19.4489520392565f,0f,0.9008889640220163f),Quaternion.Euler(0,162.21549526871397f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
skate1.transform.position = new Vector3(21.948952039256493f,0f,-0.9008889640220163f);
skate1.transform.rotation = Quaternion.Euler(0,104.91971575563191f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(21.948952039256493f,0f,-0.9008889640220163f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.38036965727347544f);
moveline1 = Instantiate(moveline,new Vector3(21.948952039256493f,0f,-0.9008889640220163f),Quaternion.Euler(0,17.784504731286034f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
}
}
public class frame421 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(19.520563590226146f,0f,0.9414036471969561f);
skate0.transform.rotation = Quaternion.Euler(0,78.08831266880492f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(19.520563590226146f,0f,0.9414036471969561f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.38939492782882174f);
moveline0 = Instantiate(moveline,new Vector3(19.520563590226146f,0f,0.9414036471969561f),Quaternion.Euler(0,165.0802842443681f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(22.02056359022614f,0f,-0.9414036471969561f);
skate1.transform.rotation = Quaternion.Euler(0,101.91168733119508f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(22.02056359022614f,0f,-0.9414036471969561f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.38939492782882174f);
moveline1 = Instantiate(moveline,new Vector3(22.02056359022614f,0f,-0.9414036471969561f),Quaternion.Euler(0,14.919715755631913f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame422 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(19.592543719373875f,0f,0.980882210242027f);
skate0.transform.rotation = Quaternion.Euler(0,81.23958054202444f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(19.592543719373875f,0f,0.980882210242027f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.39823962999148643f);
moveline0 = Instantiate(moveline,new Vector3(19.592543719373875f,0f,0.980882210242027f),Quaternion.Euler(0,168.08831266880492f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(22.092543719373868f,0f,-0.980882210242027f);
skate1.transform.rotation = Quaternion.Euler(0,98.76041945797556f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(22.092543719373868f,0f,-0.980882210242027f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.39823962999148643f);
moveline1 = Instantiate(moveline,new Vector3(22.092543719373868f,0f,-0.980882210242027f),Quaternion.Euler(0,11.911687331195097f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame423 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(19.664795818380565f,0f,1.0193225010932432f);
skate0.transform.rotation = Quaternion.Euler(0,84.53408786402667f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(19.664795818380565f,0f,1.0193225010932432f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.40690140134309216f);
moveline0 = Instantiate(moveline,new Vector3(19.664795818380565f,0f,1.0193225010932432f),Quaternion.Euler(0,171.23958054202444f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(22.164795818380558f,0f,-1.0193225010932432f);
skate1.transform.rotation = Quaternion.Euler(0,95.46591213597333f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(22.164795818380558f,0f,-1.0193225010932432f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.40690140134309216f);
moveline1 = Instantiate(moveline,new Vector3(22.164795818380558f,0f,-1.0193225010932432f),Quaternion.Euler(0,8.760419457975573f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame424 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(19.737218012975006f,0f,1.05672694451896f);
skate0.transform.rotation = Quaternion.Euler(0,87.97183463481161f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(19.737218012975006f,0f,1.05672694451896f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.41537848691449375f);
moveline0 = Instantiate(moveline,new Vector3(19.737218012975006f,0f,1.05672694451896f),Quaternion.Euler(0,174.53408786402667f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(22.237218012975f,0f,-1.05672694451896f);
skate1.transform.rotation = Quaternion.Euler(0,92.02816536518839f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(22.237218012975f,0f,-1.05672694451896f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.41537848691449375f);
moveline1 = Instantiate(moveline,new Vector3(22.237218012975f,0f,-1.05672694451896f),Quaternion.Euler(0,5.465912135973326f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame425 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(19.809703405375462f,0f,1.0931033457905024f);
skate0.transform.rotation = Quaternion.Euler(0,91.55282085437926f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(19.809703405375462f,0f,1.0931033457905024f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,0.42366994409379866f);
moveline0 = Instantiate(moveline,new Vector3(19.809703405375462f,0f,1.0931033457905024f),Quaternion.Euler(0,177.97183463481161f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(22.309703405375455f,0f,-1.0931033457905024f);
skate1.transform.rotation = Quaternion.Euler(0,88.44717914562074f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(22.309703405375455f,0f,-1.0931033457905024f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-0.42366994409379866f);
moveline1 = Instantiate(moveline,new Vector3(22.309703405375455f,0f,-1.0931033457905024f),Quaternion.Euler(0,2.0281653651883857f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame426 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(19.88214040756348f,0f,1.1256085740142059f);
skate0.transform.rotation = Quaternion.Euler(0,94.9905676251642f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(19.88214040756348f,0f,1.1256085740142059f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1682241390846113f);
moveline0 = Instantiate(moveline,new Vector3(19.88214040756348f,0f,1.1256085740142059f),Quaternion.Euler(0,-178.44717914562074f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(22.382140407563472f,0f,-1.1256085740142059f);
skate1.transform.rotation = Quaternion.Euler(0,85.0094323748358f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(22.382140407563472f,0f,-1.1256085740142059f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1682241390846113f);
moveline1 = Instantiate(moveline,new Vector3(22.382140407563472f,0f,-1.1256085740142059f),Quaternion.Euler(0,-1.5528208543792488f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame427 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(19.95442206735503f,0f,1.1542617431998892f);
skate0.transform.rotation = Quaternion.Euler(0,98.28507494716644f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(19.95442206735503f,0f,1.1542617431998892f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1609440285978958f);
moveline0 = Instantiate(moveline,new Vector3(19.95442206735503f,0f,1.1542617431998892f),Quaternion.Euler(0,-175.0094323748358f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(22.454422067355022f,0f,-1.1542617431998892f);
skate1.transform.rotation = Quaternion.Euler(0,81.71492505283356f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(22.454422067355022f,0f,-1.1542617431998892f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1609440285978958f);
moveline1 = Instantiate(moveline,new Vector3(22.454422067355022f,0f,-1.1542617431998892f),Quaternion.Euler(0,-4.9905676251642035f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame428 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(20.026446408515802f,0f,1.179086233649502f);
skate0.transform.rotation = Quaternion.Euler(0,101.43634282038596f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(20.026446408515802f,0f,1.179086233649502f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1544967331670763f);
moveline0 = Instantiate(moveline,new Vector3(20.026446408515802f,0f,1.179086233649502f),Quaternion.Euler(0,-171.71492505283356f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(22.526446408515795f,0f,-1.179086233649502f);
skate1.transform.rotation = Quaternion.Euler(0,78.56365717961404f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(22.526446408515795f,0f,-1.179086233649502f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1544967331670763f);
moveline1 = Instantiate(moveline,new Vector3(22.526446408515795f,0f,-1.179086233649502f),Quaternion.Euler(0,-8.285074947166436f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame429 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(20.09811667987583f,0f,1.2001088792392784f);
skate0.transform.rotation = Quaternion.Euler(0,104.44437124482279f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(20.09811667987583f,0f,1.2001088792392784f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1488875185005258f);
moveline0 = Instantiate(moveline,new Vector3(20.09811667987583f,0f,1.2001088792392784f),Quaternion.Euler(0,-168.56365717961404f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(22.598116679875822f,0f,-1.2001088792392784f);
skate1.transform.rotation = Quaternion.Euler(0,75.55562875517721f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(22.598116679875822f,0f,-1.2001088792392784f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1488875185005258f);
moveline1 = Instantiate(moveline,new Vector3(22.598116679875822f,0f,-1.2001088792392784f),Quaternion.Euler(0,-11.43634282038596f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame430 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(20.169341522830734f,0f,1.2173591852797812f);
skate0.transform.rotation = Quaternion.Euler(0,107.30916022047691f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(20.169341522830734f,0f,1.2173591852797812f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1441198683865315f);
moveline0 = Instantiate(moveline,new Vector3(20.169341522830734f,0f,1.2173591852797812f),Quaternion.Euler(0,-165.55562875517722f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(22.669341522830727f,0f,-1.2173591852797812f);
skate1.transform.rotation = Quaternion.Euler(0,72.69083977952309f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(22.669341522830727f,0f,-1.2173591852797812f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1441198683865315f);
moveline1 = Instantiate(moveline,new Vector3(22.669341522830727f,0f,-1.2173591852797812f),Quaternion.Euler(0,-14.444371244822776f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame431 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(20.240035066654173f,0f,1.2308685828910204f);
skate0.transform.rotation = Quaternion.Euler(0,110.03070974734831f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(20.240035066654173f,0f,1.2308685828910204f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.140195476194188f);
moveline0 = Instantiate(moveline,new Vector3(20.240035066654173f,0f,1.2308685828910204f),Quaternion.Euler(0,-162.69083977952312f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(22.740035066654166f,0f,-1.2308685828910204f);
skate1.transform.rotation = Quaternion.Euler(0,69.96929025265169f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(22.740035066654166f,0f,-1.2308685828910204f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.140195476194188f);
moveline1 = Instantiate(moveline,new Vector3(22.740035066654166f,0f,-1.2308685828910204f),Quaternion.Euler(0,-17.309160220476898f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame432 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(20.310116960912517f,0f,1.2406697243701357f);
skate0.transform.rotation = Quaternion.Euler(0,112.60901982543703f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(20.310116960912517f,0f,1.2406697243701357f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1371142662509577f);
moveline0 = Instantiate(moveline,new Vector3(20.310116960912517f,0f,1.2406697243701357f),Quaternion.Euler(0,-159.9692902526517f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(22.81011696091251f,0f,-1.2406697243701357f);
skate1.transform.rotation = Quaternion.Euler(0,67.39098017456297f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(22.81011696091251f,0f,-1.2406697243701357f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1371142662509577f);
moveline1 = Instantiate(moveline,new Vector3(22.81011696091251f,0f,-1.2406697243701357f),Quaternion.Euler(0,-20.03070974734831f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame433 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(20.379512354001452f,0f,1.2467958227212095f);
skate0.transform.rotation = Quaternion.Euler(0,115.04409045474301f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(20.379512354001452f,0f,1.2467958227212095f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1348744439715408f);
moveline0 = Instantiate(moveline,new Vector3(20.379512354001452f,0f,1.2467958227212095f),Quaternion.Euler(0,-157.39098017456297f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(22.879512354001445f,0f,-1.2467958227212095f);
skate1.transform.rotation = Quaternion.Euler(0,64.95590954525699f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(22.879512354001445f,0f,-1.2467958227212095f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1348744439715408f);
moveline1 = Instantiate(moveline,new Vector3(22.879512354001445f,0f,-1.2467958227212095f),Quaternion.Euler(0,-22.609019825437016f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame434 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(20.44815182644436f,0f,1.2492800373632327f);
skate0.transform.rotation = Quaternion.Euler(0,117.33592163526632f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(20.44815182644436f,0f,1.2492800373632327f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.133472573070054f);
moveline0 = Instantiate(moveline,new Vector3(20.44815182644436f,0f,1.2492800373632327f),Quaternion.Euler(0,-154.95590954525701f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(22.948151826444352f,0f,-1.2492800373632327f);
skate1.transform.rotation = Quaternion.Euler(0,62.66407836473368f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(22.948151826444352f,0f,-1.2492800373632327f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.133472573070054f);
moveline1 = Instantiate(moveline,new Vector3(22.948151826444352f,0f,-1.2492800373632327f),Quaternion.Euler(0,-25.044090454743f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame435 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(20.51597128713084f,0f,1.248154907031968f);
skate0.transform.rotation = Quaternion.Euler(0,119.4845133670069f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(20.51597128713084f,0f,1.248154907031968f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1329036777194585f);
moveline0 = Instantiate(moveline,new Vector3(20.51597128713084f,0f,1.248154907031968f),Quaternion.Euler(0,-152.66407836473365f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
skate1.transform.position = new Vector3(23.01597128713083f,0f,-1.248154907031968f);
skate1.transform.rotation = Quaternion.Euler(0,60.5154866329931f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(23.01597128713083f,0f,-1.248154907031968f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1329036777194585f);
moveline1 = Instantiate(moveline,new Vector3(23.01597128713083f,0f,-1.248154907031968f),Quaternion.Euler(0,-27.335921635266317f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
}
}
public class frame436 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(20.58291184015429f,0f,1.2434518300403405f);
skate0.transform.rotation = Quaternion.Euler(0,121.48986564996478f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(20.58291184015429f,0f,1.2434518300403405f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.133161367146872f);
moveline0 = Instantiate(moveline,new Vector3(20.58291184015429f,0f,1.2434518300403405f),Quaternion.Euler(0,-150.5154866329931f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(23.08291184015428f,0f,-1.2434518300403405f);
skate1.transform.rotation = Quaternion.Euler(0,58.510134350035216f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(23.08291184015428f,0f,-1.2434518300403405f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.133161367146872f);
moveline1 = Instantiate(moveline,new Vector3(23.08291184015428f,0f,-1.2434518300403405f),Quaternion.Euler(0,-29.48451336700691f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame437 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(20.648919629350154f,0f,1.2352005913535653f);
skate0.transform.rotation = Quaternion.Euler(0,123.35197848413995f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(20.648919629350154f,0f,1.2352005913535653f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.13423797988306f);
moveline0 = Instantiate(moveline,new Vector3(20.648919629350154f,0f,1.2352005913535653f),Quaternion.Euler(0,-148.5101343500352f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
skate1.transform.position = new Vector3(23.148919629350146f,0f,-1.2352005913535653f);
skate1.transform.rotation = Quaternion.Euler(0,56.648021515860044f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(23.148919629350146f,0f,-1.2352005913535653f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.13423797988306f);
moveline1 = Instantiate(moveline,new Vector3(23.148919629350146f,0f,-1.2352005913535653f),Quaternion.Euler(0,-31.4898656499648f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
}
}
public class frame438 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(20.713945667058866f,0f,1.2234289353612686f);
skate0.transform.rotation = Quaternion.Euler(0,125.07085186953243f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(20.713945667058866f,0f,1.2234289353612686f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1361247447251468f);
moveline0 = Instantiate(moveline,new Vector3(20.713945667058866f,0f,1.2234289353612686f),Quaternion.Euler(0,-146.64802151586005f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(23.21394566705886f,0f,-1.2234289353612686f);
skate1.transform.rotation = Quaternion.Euler(0,54.92914813046757f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(23.21394566705886f,0f,-1.2234289353612686f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1361247447251468f);
moveline1 = Instantiate(moveline,new Vector3(23.21394566705886f,0f,-1.2234289353612686f),Quaternion.Euler(0,-33.35197848413996f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame439 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(20.77794565305391f,0f,1.2081621827799112f);
skate0.transform.rotation = Quaternion.Euler(0,126.6464858061422f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(20.77794565305391f,0f,1.2081621827799112f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1388119554238638f);
moveline0 = Instantiate(moveline,new Vector3(20.77794565305391f,0f,1.2081621827799112f),Quaternion.Euler(0,-144.92914813046755f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(23.2779456530539f,0f,-1.2081621827799112f);
skate1.transform.rotation = Quaternion.Euler(0,53.353514193857805f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(23.2779456530539f,0f,-1.2081621827799112f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1388119554238638f);
moveline1 = Instantiate(moveline,new Vector3(23.2779456530539f,0f,-1.2081621827799112f),Quaternion.Euler(0,-35.07085186953245f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame440 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(20.840879788997416f,0f,1.1894228897845718f);
skate0.transform.rotation = Quaternion.Euler(0,128.07888029396923f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(20.840879788997416f,0f,1.1894228897845718f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1422891561657678f);
moveline0 = Instantiate(moveline,new Vector3(20.840879788997416f,0f,1.1894228897845718f),Quaternion.Euler(0,-143.3535141938578f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(23.34087978899741f,0f,-1.1894228897845718f);
skate1.transform.rotation = Quaternion.Euler(0,51.92111970603075f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(23.34087978899741f,0f,-1.1894228897845718f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1422891561657678f);
moveline1 = Instantiate(moveline,new Vector3(23.34087978899741f,0f,-1.1894228897845718f),Quaternion.Euler(0,-36.646485806142195f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame441 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(20.902712593222418f,0f,1.1672305472389035f);
skate0.transform.rotation = Quaternion.Euler(0,129.3680353330136f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(20.902712593222418f,0f,1.1672305472389035f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1465453350781263f);
moveline0 = Instantiate(moveline,new Vector3(20.902712593222418f,0f,1.1672305472389035f),Quaternion.Euler(0,-141.92111970603077f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(23.40271259322241f,0f,-1.1672305472389035f);
skate1.transform.rotation = Quaternion.Euler(0,50.6319646669864f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(23.40271259322241f,0f,-1.1672305472389035f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1465453350781263f);
moveline1 = Instantiate(moveline,new Vector3(23.40271259322241f,0f,-1.1672305472389035f),Quaternion.Euler(0,-38.07888029396926f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame442 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(20.96341272009897f,0f,1.1416013177549775f);
skate0.transform.rotation = Quaternion.Euler(0,130.51395092327525f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(20.96341272009897f,0f,1.1416013177549775f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1515691232277991f);
moveline0 = Instantiate(moveline,new Vector3(20.96341272009897f,0f,1.1416013177549775f),Quaternion.Euler(0,-140.63196466698642f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(23.46341272009896f,0f,-1.1416013177549775f);
skate1.transform.rotation = Quaternion.Euler(0,49.486049076724754f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(23.46341272009896f,0f,-1.1416013177549775f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1515691232277991f);
moveline1 = Instantiate(moveline,new Vector3(23.46341272009896f,0f,-1.1416013177549775f),Quaternion.Euler(0,-39.36803533301361f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame443 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(21.022952787725558f,0f,1.1125478082600646f);
skate0.transform.rotation = Quaternion.Euler(0,131.51662706475418f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(21.022952787725558f,0f,1.1125478082600646f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1573489969019226f);
moveline0 = Instantiate(moveline,new Vector3(21.022952787725558f,0f,1.1125478082600646f),Quaternion.Euler(0,-139.48604907672475f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(23.52295278772555f,0f,-1.1125478082600646f);
skate1.transform.rotation = Quaternion.Euler(0,48.48337293524581f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(23.52295278772555f,0f,-1.1125478082600646f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1573489969019226f);
moveline1 = Instantiate(moveline,new Vector3(23.52295278772555f,0f,-1.1125478082600646f),Quaternion.Euler(0,-40.513950923275246f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame444 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(21.0813092172003f,0f,1.0800788757647553f);
skate0.transform.rotation = Quaternion.Euler(0,132.37606375745042f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(21.0813092172003f,0f,1.0800788757647553f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1638734813334248f);
moveline0 = Instantiate(moveline,new Vector3(21.0813092172003f,0f,1.0800788757647553f),Quaternion.Euler(0,-138.4833729352458f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(23.581309217200292f,0f,-1.0800788757647553f);
skate1.transform.rotation = Quaternion.Euler(0,47.623936242549576f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(23.581309217200292f,0f,-1.0800788757647553f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1638734813334248f);
moveline1 = Instantiate(moveline,new Vector3(23.581309217200292f,0f,-1.0800788757647553f),Quaternion.Euler(0,-41.5166270647542f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame445 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(21.13846208626962f,0f,1.0441994641062196f);
skate0.transform.rotation = Quaternion.Euler(0,133.09226100136397f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(21.13846208626962f,0f,1.0441994641062196f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1711313544546353f);
moveline0 = Instantiate(moveline,new Vector3(21.13846208626962f,0f,1.0441994641062196f),Quaternion.Euler(0,-137.62393624254958f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(23.638462086269612f,0f,-1.0441994641062196f);
skate1.transform.rotation = Quaternion.Euler(0,46.90773899863605f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(23.638462086269612f,0f,-1.0441994641062196f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1711313544546353f);
moveline1 = Instantiate(moveline,new Vector3(23.638462086269612f,0f,-1.0441994641062196f),Quaternion.Euler(0,-42.376063757450396f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame446 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(21.1943949997252f,0f,1.0049104695724127f);
skate0.transform.rotation = Quaternion.Euler(0,133.66521879649477f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(21.1943949997252f,0f,1.0049104695724127f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1791118497152961f);
moveline0 = Instantiate(moveline,new Vector3(21.1943949997252f,0f,1.0049104695724127f),Quaternion.Euler(0,-136.90773899863606f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(23.694394999725194f,0f,-1.0049104695724127f);
skate1.transform.rotation = Quaternion.Euler(0,46.33478120350523f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(23.694394999725194f,0f,-1.0049104695724127f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1791118497152961f);
moveline1 = Instantiate(moveline,new Vector3(23.694394999725194f,0f,-1.0049104695724127f),Quaternion.Euler(0,-43.09226100136394f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame447 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(21.249094978521644f,0f,0.962208633488758f);
skate0.transform.rotation = Quaternion.Euler(0,134.0949371428429f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(21.249094978521644f,0f,0.962208633488758f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1878048574770546f);
moveline0 = Instantiate(moveline,new Vector3(21.249094978521644f,0f,0.962208633488758f),Quaternion.Euler(0,-136.33478120350523f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(23.749094978521637f,0f,-0.962208633488758f);
skate1.transform.rotation = Quaternion.Euler(0,45.90506285715711f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(23.749094978521637f,0f,-0.962208633488758f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1878048574770546f);
moveline1 = Instantiate(moveline,new Vector3(23.749094978521637f,0f,-0.962208633488758f),Quaternion.Euler(0,-43.66521879649477f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame448 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(21.302552369215043f,0f,0.9160864600600024f);
skate0.transform.rotation = Quaternion.Euler(0,134.38141604040828f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(21.302552369215043f,0f,0.9160864600600024f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.1972011249877952f);
moveline0 = Instantiate(moveline,new Vector3(21.302552369215043f,0f,0.9160864600600024f),Quaternion.Euler(0,-135.9050628571571f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(23.802552369215036f,0f,-0.9160864600600024f);
skate1.transform.rotation = Quaternion.Euler(0,45.6185839595917f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(23.802552369215036f,0f,-0.9160864600600024f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.1972011249877952f);
moveline1 = Instantiate(moveline,new Vector3(23.802552369215036f,0f,-0.9160864600600024f),Quaternion.Euler(0,-44.094937142842895f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame449 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(21.354760774973474f,0f,0.866532157998764f);
skate0.transform.rotation = Quaternion.Euler(0,134.524655489191f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(21.354760774973474f,0f,0.866532157998764f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2072924554420115f);
moveline0 = Instantiate(moveline,new Vector3(21.354760774973474f,0f,0.866532157998764f),Quaternion.Euler(0,-135.6185839595917f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(23.854760774973467f,0f,-0.866532157998764f);
skate1.transform.rotation = Quaternion.Euler(0,45.475344510808995f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(23.854760774973467f,0f,-0.866532157998764f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2072924554420115f);
moveline1 = Instantiate(moveline,new Vector3(23.854760774973467f,0f,-0.866532157998764f),Quaternion.Euler(0,-44.38141604040831f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame450 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(21.405717009080213f,0f,0.8135296047315019f);
skate0.transform.rotation = Quaternion.Euler(0,134.524655489191f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(21.405717009080213f,0f,0.8135296047315019f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-1.2180719071475454f);
moveline0 = Instantiate(moveline,new Vector3(21.405717009080213f,0f,0.8135296047315019f),Quaternion.Euler(0,-135.475344510809f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
skate1.transform.position = new Vector3(23.905717009080206f,0f,-0.8135296047315019f);
skate1.transform.rotation = Quaternion.Euler(0,45.475344510808995f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(23.905717009080206f,0f,-0.8135296047315019f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,1.2180719071475454f);
moveline1 = Instantiate(moveline,new Vector3(23.905717009080206f,0f,-0.8135296047315019f),Quaternion.Euler(0,-44.52465548919096f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
}
}
public class frame451 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(21.457925414838645f,0f,0.7617474349890213f);
skate0.transform.rotation = Quaternion.Euler(0,134.38141604040828f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(21.457925414838645f,0f,0.7617474349890213f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.029533994348148917f);
moveline0 = Instantiate(moveline,new Vector3(21.457925414838645f,0f,0.7617474349890213f),Quaternion.Euler(0,44.52465548919101f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(23.957925414838638f,0f,-0.7617474349890213f);
skate1.transform.rotation = Quaternion.Euler(0,45.61858395959171f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(23.957925414838638f,0f,-0.7617474349890213f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.029533994348148917f);
moveline1 = Instantiate(moveline,new Vector3(23.957925414838638f,0f,-0.7617474349890213f),Quaternion.Euler(0,135.47534451080898f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame452 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(21.510097517067f,0f,0.7099297372630913f);
skate0.transform.rotation = Quaternion.Euler(0,134.09493714284287f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(21.510097517067f,0f,0.7099297372630913f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.04066943423067011f);
moveline0 = Instantiate(moveline,new Vector3(21.510097517067f,0f,0.7099297372630913f),Quaternion.Euler(0,-44.38141604040831f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.029066427512593123f);
skate1.transform.position = new Vector3(24.010097517066992f,0f,-0.7099297372630913f);
skate1.transform.rotation = Quaternion.Euler(0,45.90506285715712f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(24.010097517066992f,0f,-0.7099297372630913f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.04066943423067011f);
moveline1 = Instantiate(moveline,new Vector3(24.010097517066992f,0f,-0.7099297372630913f),Quaternion.Euler(0,-135.6185839595917f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.029066427512593123f);
}
}
public class frame453 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(21.563512207398393f,0f,0.6593020981766547f);
skate0.transform.rotation = Quaternion.Euler(0,133.66521879649477f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(21.563512207398393f,0f,0.6593020981766547f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.05175495015226592f);
moveline0 = Instantiate(moveline,new Vector3(21.563512207398393f,0f,0.6593020981766547f),Quaternion.Euler(0,44.09493714284289f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(24.063512207398386f,0f,-0.6593020981766547f);
skate1.transform.rotation = Quaternion.Euler(0,46.33478120350523f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(24.063512207398386f,0f,-0.6593020981766547f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.05175495015226592f);
moveline1 = Instantiate(moveline,new Vector3(24.063512207398386f,0f,-0.6593020981766547f),Quaternion.Euler(0,135.9050628571571f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame454 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(21.6168711240034f,0f,0.6086212252981114f);
skate0.transform.rotation = Quaternion.Euler(0,133.09226100136394f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(21.6168711240034f,0f,0.6086212252981114f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.06253443851164027f);
moveline0 = Instantiate(moveline,new Vector3(21.6168711240034f,0f,0.6086212252981114f),Quaternion.Euler(0,-43.66521879649477f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.045236563003678856f);
skate1.transform.position = new Vector3(24.116871124003392f,0f,-0.6086212252981114f);
skate1.transform.rotation = Quaternion.Euler(0,46.907738998636056f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(24.116871124003392f,0f,-0.6086212252981114f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.06253443851164027f);
moveline1 = Instantiate(moveline,new Vector3(24.116871124003392f,0f,-0.6086212252981114f),Quaternion.Euler(0,-136.33478120350523f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.045236563003678856f);
}
}
public class frame455 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(21.670164758517643f,0f,0.5578792790567253f);
skate0.transform.rotation = Quaternion.Euler(0,132.37606375745042f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(21.670164758517643f,0f,0.5578792790567253f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.07327836105093259f);
moveline0 = Instantiate(moveline,new Vector3(21.670164758517643f,0f,0.5578792790567253f),Quaternion.Euler(0,-43.09226100136394f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.053511857338758795f);
skate1.transform.position = new Vector3(24.170164758517636f,0f,-0.5578792790567253f);
skate1.transform.rotation = Quaternion.Euler(0,47.62393624254958f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(24.170164758517636f,0f,-0.5578792790567253f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.07327836105093259f);
moveline1 = Instantiate(moveline,new Vector3(24.170164758517636f,0f,-0.5578792790567253f),Quaternion.Euler(0,-136.90773899863606f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.053511857338758795f);
}
}
public class frame456 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(21.724661953437312f,0f,0.5083065200303993f);
skate0.transform.rotation = Quaternion.Euler(0,131.51662706475418f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(21.724661953437312f,0f,0.5083065200303993f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.08399213651837585f);
moveline0 = Instantiate(moveline,new Vector3(21.724661953437312f,0f,0.5083065200303993f),Quaternion.Euler(0,42.37606375745042f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(24.224661953437305f,0f,-0.5083065200303993f);
skate1.transform.rotation = Quaternion.Euler(0,48.48337293524582f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(24.224661953437305f,0f,-0.5083065200303993f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.08399213651837585f);
moveline1 = Instantiate(moveline,new Vector3(24.224661953437305f,0f,-0.5083065200303993f),Quaternion.Euler(0,137.62393624254958f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame457 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(21.780342786508825f,0f,0.4599022294095404f);
skate0.transform.rotation = Quaternion.Euler(0,130.51395092327525f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(21.780342786508825f,0f,0.4599022294095404f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.09442109182714468f);
moveline0 = Instantiate(moveline,new Vector3(21.780342786508825f,0f,0.4599022294095404f),Quaternion.Euler(0,41.516627064754196f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(24.280342786508818f,0f,-0.4599022294095404f);
skate1.transform.rotation = Quaternion.Euler(0,49.486049076724754f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(24.280342786508818f,0f,-0.4599022294095404f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.09442109182714468f);
moveline1 = Instantiate(moveline,new Vector3(24.280342786508818f,0f,-0.4599022294095404f),Quaternion.Euler(0,138.4833729352458f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame458 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(21.83593139463383f,0f,0.411419132398783f);
skate0.transform.rotation = Quaternion.Euler(0,129.3680353330136f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(21.83593139463383f,0f,0.411419132398783f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.10457143393277142f);
moveline0 = Instantiate(moveline,new Vector3(21.83593139463383f,0f,0.411419132398783f),Quaternion.Euler(0,-40.513950923275246f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.07950020355759903f);
skate1.transform.position = new Vector3(24.33593139463382f,0f,-0.411419132398783f);
skate1.transform.rotation = Quaternion.Euler(0,50.631964666986406f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(24.33593139463382f,0f,-0.411419132398783f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.10457143393277142f);
moveline1 = Instantiate(moveline,new Vector3(24.33593139463382f,0f,-0.411419132398783f),Quaternion.Euler(0,-139.48604907672475f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.07950020355759903f);
}
}
public class frame459 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(21.892652680107282f,0f,0.3641117112388815f);
skate0.transform.rotation = Quaternion.Euler(0,128.07888029396923f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(21.892652680107282f,0f,0.3641117112388815f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.1147090857172317f);
moveline0 = Instantiate(moveline,new Vector3(21.892652680107282f,0f,0.3641117112388815f),Quaternion.Euler(0,39.3680353330136f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(24.392652680107275f,0f,-0.3641117112388815f);
skate1.transform.rotation = Quaternion.Euler(0,51.92111970603076f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(24.392652680107275f,0f,-0.3641117112388815f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.1147090857172317f);
moveline1 = Instantiate(moveline,new Vector3(24.392652680107275f,0f,-0.3641117112388815f),Quaternion.Euler(0,140.6319646669864f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame460 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(21.950475297299242f,0f,0.3179874804912435f);
skate0.transform.rotation = Quaternion.Euler(0,126.64648580614218f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(21.950475297299242f,0f,0.3179874804912435f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.12457578223847351f);
moveline0 = Instantiate(moveline,new Vector3(21.950475297299242f,0f,0.3179874804912435f),Quaternion.Euler(0,38.07888029396925f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(24.450475297299235f,0f,-0.3179874804912435f);
skate1.transform.rotation = Quaternion.Euler(0,53.35351419385781f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(24.450475297299235f,0f,-0.3179874804912435f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.12457578223847351f);
moveline1 = Instantiate(moveline,new Vector3(24.450475297299235f,0f,-0.3179874804912435f),Quaternion.Euler(0,141.92111970603077f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame461 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(22.009363764542737f,0f,0.27305639052099284f);
skate0.transform.rotation = Quaternion.Euler(0,125.07085186953242f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(22.009363764542737f,0f,0.27305639052099284f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.1341746403271973f);
moveline0 = Instantiate(moveline,new Vector3(22.009363764542737f,0f,0.27305639052099284f),Quaternion.Euler(0,36.646485806142195f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(24.50936376454273f,0f,-0.27305639052099284f);
skate1.transform.rotation = Quaternion.Euler(0,54.929148130467574f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(24.50936376454273f,0f,-0.27305639052099284f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.1341746403271973f);
moveline1 = Instantiate(moveline,new Vector3(24.50936376454273f,0f,-0.27305639052099284f),Quaternion.Euler(0,143.3535141938578f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame462 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(22.0692782834999f,0f,0.22933054045885504f);
skate0.transform.rotation = Quaternion.Euler(0,123.35197848413995f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(22.0692782834999f,0f,0.22933054045885504f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.14350778590692703f);
moveline0 = Instantiate(moveline,new Vector3(22.0692782834999f,0f,0.22933054045885504f),Quaternion.Euler(0,35.07085186953243f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(24.569278283499894f,0f,-0.22933054045885504f);
skate1.transform.rotation = Quaternion.Euler(0,56.648021515860044f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(24.569278283499894f,0f,-0.22933054045885504f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.14350778590692703f);
moveline1 = Instantiate(moveline,new Vector3(24.569278283499894f,0f,-0.22933054045885504f),Quaternion.Euler(0,144.92914813046758f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame463 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(22.13017455394422f,0f,0.18682385556984316f);
skate0.transform.rotation = Quaternion.Euler(0,121.48986564996477f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(22.13017455394422f,0f,0.18682385556984316f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.15257644941636067f);
moveline0 = Instantiate(moveline,new Vector3(22.13017455394422f,0f,0.18682385556984316f),Quaternion.Euler(0,33.351978484139956f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(24.63017455394421f,0f,-0.18682385556984316f);
skate1.transform.rotation = Quaternion.Euler(0,58.51013435003522f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(24.63017455394421f,0f,-0.18682385556984316f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.15257644941636067f);
moveline1 = Instantiate(moveline,new Vector3(24.63017455394421f,0f,-0.18682385556984316f),Quaternion.Euler(0,146.64802151586005f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame464 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(22.19200358821612f,0f,0.1455517269405911f);
skate0.transform.rotation = Quaternion.Euler(0,119.4845133670069f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(22.19200358821612f,0f,0.1455517269405911f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.1613810639342666f);
moveline0 = Instantiate(moveline,new Vector3(22.19200358821612f,0f,0.1455517269405911f),Quaternion.Euler(0,31.48986564996477f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(24.692003588216114f,0f,-0.1455517269405911f);
skate1.transform.rotation = Quaternion.Euler(0,60.5154866329931f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(24.692003588216114f,0f,-0.1455517269405911f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.1613810639342666f);
moveline1 = Instantiate(moveline,new Vector3(24.692003588216114f,0f,-0.1455517269405911f),Quaternion.Euler(0,148.51013435003523f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame465 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(22.254711530151052f,0f,0.10553061151723306f);
skate0.transform.rotation = Quaternion.Euler(0,117.3359216352663f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(22.254711530151052f,0f,0.10553061151723306f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.16992136735556945f);
moveline0 = Instantiate(moveline,new Vector3(22.254711530151052f,0f,0.10553061151723306f),Quaternion.Euler(0,29.48451336700691f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(24.754711530151045f,0f,-0.10553061151723306f);
skate1.transform.rotation = Quaternion.Euler(0,62.6640783647337f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(24.754711530151045f,0f,-0.10553061151723306f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.16992136735556945f);
moveline1 = Instantiate(moveline,new Vector3(24.754711530151045f,0f,-0.10553061151723306f),Quaternion.Euler(0,150.5154866329931f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame466 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(22.31823948384241f,0f,0.06677759073219919f);
skate0.transform.rotation = Quaternion.Euler(0,115.04409045474301f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(22.31823948384241f,0f,0.06677759073219919f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.17819650986024527f);
moveline0 = Instantiate(moveline,new Vector3(22.31823948384241f,0f,0.06677759073219919f),Quaternion.Euler(0,27.335921635266303f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(24.818239483842405f,0f,-0.06677759073219919f);
skate1.transform.rotation = Quaternion.Euler(0,64.95590954525699f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(24.818239483842405f,0f,-0.06677759073219919f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.17819650986024527f);
moveline1 = Instantiate(moveline,new Vector3(24.818239483842405f,0f,-0.06677759073219919f),Quaternion.Euler(0,152.6640783647337f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame467 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(22.3825233581798f,0f,0.02930988626180986f);
skate0.transform.rotation = Quaternion.Euler(0,112.609019825437f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(22.3825233581798f,0f,0.02930988626180986f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.18620516779734783f);
moveline0 = Instantiate(moveline,new Vector3(22.3825233581798f,0f,0.02930988626180986f),Quaternion.Euler(0,25.044090454743014f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(24.882523358179792f,0f,-0.02930988626180986f);
skate1.transform.rotation = Quaternion.Euler(0,67.390980174563f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(24.882523358179792f,0f,-0.02930988626180986f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.18620516779734783f);
moveline1 = Instantiate(moveline,new Vector3(24.882523358179792f,0f,-0.02930988626180986f),Quaternion.Euler(0,154.955909545257f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame468 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(22.447493733686592f,0f,-0.00685566813221785f);
skate0.transform.rotation = Quaternion.Euler(0,110.03070974734831f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(22.447493733686592f,0f,-0.00685566813221785f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.19394566496917592f);
moveline0 = Instantiate(moveline,new Vector3(22.447493733686592f,0f,-0.00685566813221785f),Quaternion.Euler(0,22.609019825437016f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(24.947493733686585f,0f,0.00685566813221785f);
skate1.transform.rotation = Quaternion.Euler(0,69.96929025265169f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(24.947493733686585f,0f,0.00685566813221785f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.19394566496917592f);
moveline1 = Instantiate(moveline,new Vector3(24.947493733686585f,0f,0.00685566813221785f),Quaternion.Euler(0,157.39098017456297f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame469 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(22.513075758758482f,0f,-0.04170319919481982f);
skate0.transform.rotation = Quaternion.Euler(0,107.30916022047688f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(22.513075758758482f,0f,-0.04170319919481982f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.20141610214005565f);
moveline0 = Instantiate(moveline,new Vector3(22.513075758758482f,0f,-0.04170319919481982f),Quaternion.Euler(0,20.030709747348297f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(25.013075758758475f,0f,0.04170319919481982f);
skate1.transform.rotation = Quaternion.Euler(0,72.69083977952312f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(25.013075758758475f,0f,0.04170319919481982f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.20141610214005565f);
moveline1 = Instantiate(moveline,new Vector3(25.013075758758475f,0f,0.04170319919481982f),Quaternion.Euler(0,159.96929025265172f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame470 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(22.57918908296184f,0f,-0.07521841106315832f);
skate0.transform.rotation = Quaternion.Euler(0,104.44437124482278f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(22.57918908296184f,0f,-0.07521841106315832f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.208614495405849f);
moveline0 = Instantiate(moveline,new Vector3(22.57918908296184f,0f,-0.07521841106315832f),Quaternion.Euler(0,17.309160220476898f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(25.079189082961832f,0f,0.07521841106315832f);
skate1.transform.rotation = Quaternion.Euler(0,75.55562875517722f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(25.079189082961832f,0f,0.07521841106315832f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.208614495405849f);
moveline1 = Instantiate(moveline,new Vector3(25.079189082961832f,0f,0.07521841106315832f),Quaternion.Euler(0,162.69083977952312f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame471 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(22.64574783557032f,0f,-0.10738924551119983f);
skate0.transform.rotation = Quaternion.Euler(0,101.43634282038595f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(22.64574783557032f,0f,-0.10738924551119983f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.21553892384031287f);
moveline0 = Instantiate(moveline,new Vector3(22.64574783557032f,0f,-0.10738924551119983f),Quaternion.Euler(0,14.444371244822776f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(25.14574783557031f,0f,0.10738924551119983f);
skate1.transform.rotation = Quaternion.Euler(0,78.56365717961405f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(25.14574783557031f,0f,0.10738924551119983f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.21553892384031287f);
moveline1 = Instantiate(moveline,new Vector3(25.14574783557031f,0f,0.10738924551119983f),Quaternion.Euler(0,165.55562875517722f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame472 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(22.712660657979544f,0f,-0.13820658367990582f);
skate0.transform.rotation = Quaternion.Euler(0,98.28507494716642f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(22.712660657979544f,0f,-0.13820658367990582f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.2221876865800095f);
moveline0 = Instantiate(moveline,new Vector3(22.712660657979544f,0f,-0.13820658367990582f),Quaternion.Euler(0,11.43634282038596f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(25.212660657979537f,0f,0.13820658367990582f);
skate1.transform.rotation = Quaternion.Euler(0,81.71492505283358f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(25.212660657979537f,0f,0.13820658367990582f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.2221876865800095f);
moveline1 = Instantiate(moveline,new Vector3(25.212660657979537f,0f,0.13820658367990582f),Quaternion.Euler(0,168.56365717961404f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame473 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(22.779830799019546f,0f,-0.16766498633108795f);
skate0.transform.rotation = Quaternion.Euler(0,94.99056762516419f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(22.779830799019546f,0f,-0.16766498633108795f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.22855946921901152f);
moveline0 = Instantiate(moveline,new Vector3(22.779830799019546f,0f,-0.16766498633108795f),Quaternion.Euler(0,8.285074947166422f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(25.27983079901954f,0f,0.16766498633108795f);
skate1.transform.rotation = Quaternion.Euler(0,85.00943237483581f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(25.27983079901954f,0f,0.16766498633108795f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.22855946921901152f);
moveline1 = Instantiate(moveline,new Vector3(25.27983079901954f,0f,0.16766498633108795f),Quaternion.Euler(0,171.71492505283356f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame474 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(22.847156282456016f,0f,-0.19576346842220674f);
skate0.transform.rotation = Quaternion.Euler(0,91.55282085437925f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(22.847156282456016f,0f,-0.19576346842220674f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.23465351905797718f);
moveline0 = Instantiate(moveline,new Vector3(22.847156282456016f,0f,-0.19576346842220674f),Quaternion.Euler(0,4.990567625164189f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(25.34715628245601f,0f,0.19576346842220674f);
skate1.transform.rotation = Quaternion.Euler(0,88.44717914562075f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(25.34715628245601f,0f,0.19576346842220674f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.23465351905797718f);
moveline1 = Instantiate(moveline,new Vector3(25.34715628245601f,0f,0.19576346842220674f),Quaternion.Euler(0,175.0094323748358f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame475 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(22.914530156104924f,0f,-0.2225063024074069f);
skate0.transform.rotation = Quaternion.Euler(0,87.9718346348116f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(22.914530156104924f,0f,-0.2225063024074069f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,-0.24046982839075115f);
moveline0 = Instantiate(moveline,new Vector3(22.914530156104924f,0f,-0.2225063024074069f),Quaternion.Euler(0,1.5528208543792488f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(25.414530156104917f,0f,0.2225063024074069f);
skate1.transform.rotation = Quaternion.Euler(0,92.0281653651884f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(25.414530156104917f,0f,0.2225063024074069f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,0.24046982839075115f);
moveline1 = Instantiate(moveline,new Vector3(25.414530156104917f,0f,0.2225063024074069f),Quaternion.Euler(0,178.44717914562074f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame476 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(22.981840831947817f,0f,-0.24504670027508427f);
skate0.transform.rotation = Quaternion.Euler(0,84.53408786402666f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(22.981840831947817f,0f,-0.24504670027508427f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3539906753812854f);
moveline0 = Instantiate(moveline,new Vector3(22.981840831947817f,0f,-0.24504670027508427f),Quaternion.Euler(0,-2.0281653651883857f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(25.48184083194781f,0f,0.24504670027508427f);
skate1.transform.rotation = Quaternion.Euler(0,95.46591213597334f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(25.48184083194781f,0f,0.24504670027508427f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3539906753812854f);
moveline1 = Instantiate(moveline,new Vector3(25.48184083194781f,0f,0.24504670027508427f),Quaternion.Euler(0,-177.97183463481161f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame477 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(23.04898141220296f,0f,-0.26340000626672017f);
skate0.transform.rotation = Quaternion.Euler(0,81.23958054202441f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(23.04898141220296f,0f,-0.26340000626672017f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3493184053891414f);
moveline0 = Instantiate(moveline,new Vector3(23.04898141220296f,0f,-0.26340000626672017f),Quaternion.Euler(0,-5.4659121359733405f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(25.548981412202952f,0f,0.26340000626672017f);
skate1.transform.rotation = Quaternion.Euler(0,98.76041945797559f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(25.548981412202952f,0f,0.26340000626672017f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3493184053891414f);
moveline1 = Instantiate(moveline,new Vector3(25.548981412202952f,0f,0.26340000626672017f),Quaternion.Euler(0,-174.53408786402667f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame478 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(23.11585002259914f,0f,-0.2775857310964237f);
skate0.transform.rotation = Quaternion.Euler(0,78.08831266880489f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(23.11585002259914f,0f,-0.2775857310964237f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3455116207802928f);
moveline0 = Instantiate(moveline,new Vector3(23.11585002259914f,0f,-0.2775857310964237f),Quaternion.Euler(0,-8.760419457975573f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(25.615850022599133f,0f,0.2775857310964237f);
skate1.transform.rotation = Quaternion.Euler(0,101.91168733119511f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(25.615850022599133f,0f,0.2775857310964237f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3455116207802928f);
moveline1 = Instantiate(moveline,new Vector3(25.615850022599133f,0f,0.2775857310964237f),Quaternion.Euler(0,-171.23958054202444f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame479 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(23.18235005481724f,0f,-0.2876267513640466f);
skate0.transform.rotation = Quaternion.Euler(0,75.08028424436807f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(23.18235005481724f,0f,-0.2876267513640466f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3425676520471126f);
moveline0 = Instantiate(moveline,new Vector3(23.18235005481724f,0f,-0.2876267513640466f),Quaternion.Euler(0,-11.911687331195097f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
skate1.transform.position = new Vector3(25.68235005481723f,0f,0.2876267513640466f);
skate1.transform.rotation = Quaternion.Euler(0,104.91971575563193f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(25.68235005481723f,0f,0.2876267513640466f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3425676520471126f);
moveline1 = Instantiate(moveline,new Vector3(25.68235005481723f,0f,0.2876267513640466f),Quaternion.Euler(0,-168.08831266880492f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,0.9999999999999998f);
}
}
public class frame480 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(23.248390327548513f,0f,-0.2935485386292658f);
skate0.transform.rotation = Quaternion.Euler(0,72.21549526871395f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(23.248390327548513f,0f,-0.2935485386292658f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.340482939877683f);
moveline0 = Instantiate(moveline,new Vector3(23.248390327548513f,0f,-0.2935485386292658f),Quaternion.Euler(0,-14.919715755631941f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(25.748390327548506f,0f,0.2935485386292658f);
skate1.transform.rotation = Quaternion.Euler(0,107.78450473128605f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(25.748390327548506f,0f,0.2935485386292658f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.340482939877683f);
moveline1 = Instantiate(moveline,new Vector3(25.748390327548506f,0f,0.2935485386292658f),Quaternion.Euler(0,-165.08028424436807f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame481 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(23.313885175642962f,0f,-0.2953784238741458f);
skate0.transform.rotation = Quaternion.Euler(0,69.49394574184254f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(23.313885175642962f,0f,-0.2953784238741458f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3392531001728032f);
moveline0 = Instantiate(moveline,new Vector3(23.313885175642962f,0f,-0.2953784238741458f),Quaternion.Euler(0,-17.78450473128605f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(25.813885175642955f,0f,0.2953784238741458f);
skate1.transform.rotation = Quaternion.Euler(0,110.50605425815746f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(25.813885175642955f,0f,0.2953784238741458f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3392531001728032f);
moveline1 = Instantiate(moveline,new Vector3(25.813885175642955f,0f,0.2953784238741458f),Quaternion.Euler(0,-162.21549526871394f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame482 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(23.378754476675986f,0f,-0.2931449016330322f);
skate0.transform.rotation = Quaternion.Euler(0,66.91563566375383f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(23.378754476675986f,0f,-0.2931449016330322f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3388730134089686f);
moveline0 = Instantiate(moveline,new Vector3(23.378754476675986f,0f,-0.2931449016330322f),Quaternion.Euler(0,-20.506054258157448f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(25.87875447667598f,0f,0.2931449016330322f);
skate1.transform.rotation = Quaternion.Euler(0,113.08436433624617f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(25.87875447667598f,0f,0.2931449016330322f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3388730134089686f);
moveline1 = Instantiate(moveline,new Vector3(25.87875447667598f,0f,0.2931449016330322f),Quaternion.Euler(0,-159.49394574184254f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame483 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(23.44292362397972f,0f,-0.2868769767744089f);
skate0.transform.rotation = Quaternion.Euler(0,64.48056503444784f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(23.44292362397972f,0f,-0.2868769767744089f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3393369363632432f);
moveline0 = Instantiate(moveline,new Vector3(23.44292362397972f,0f,-0.2868769767744089f),Quaternion.Euler(0,-23.084364336246168f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(25.942923623979713f,0f,0.2868769767744089f);
skate1.transform.rotation = Quaternion.Euler(0,115.51943496555216f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(25.942923623979713f,0f,0.2868769767744089f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3393369363632432f);
moveline1 = Instantiate(moveline,new Vector3(25.942923623979713f,0f,0.2868769767744089f),Quaternion.Euler(0,-156.91563566375385f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame484 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(23.50632345479649f,0f,-0.27660355578112455f);
skate0.transform.rotation = Quaternion.Euler(0,62.18873385392453f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(23.50632345479649f,0f,-0.27660355578112455f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3406386341288545f);
moveline0 = Instantiate(moveline,new Vector3(23.50632345479649f,0f,-0.27660355578112455f),Quaternion.Euler(0,-25.519434965552165f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(26.006323454796483f,0f,0.27660355578112455f);
skate1.transform.rotation = Quaternion.Euler(0,117.81126614607547f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(26.006323454796483f,0f,0.27660355578112455f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3406386341288545f);
moveline1 = Instantiate(moveline,new Vector3(26.006323454796483f,0f,0.27660355578112455f),Quaternion.Euler(0,-154.48056503444784f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame485 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(23.568890141742425f,0f,-0.2623528833909974f);
skate0.transform.rotation = Quaternion.Euler(0,60.04014212218395f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(23.568890141742425f,0f,-0.2623528833909974f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3427715303484309f);
moveline0 = Instantiate(moveline,new Vector3(23.568890141742425f,0f,-0.2623528833909974f),Quaternion.Euler(0,-27.811266146075468f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(26.06889014174242f,0f,0.2623528833909974f);
skate1.transform.rotation = Quaternion.Euler(0,119.95985787781605f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(26.06889014174242f,0f,0.2623528833909974f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3427715303484309f);
moveline1 = Instantiate(moveline,new Vector3(26.06889014174242f,0f,0.2623528833909974f),Quaternion.Euler(0,-152.18873385392453f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame486 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(23.630565055243054f,0f,-0.2441520246241059f);
skate0.transform.rotation = Quaternion.Euler(0,58.034789839226065f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(23.630565055243054f,0f,-0.2441520246241059f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3457288736793318f);
moveline0 = Instantiate(moveline,new Vector3(23.630565055243054f,0f,-0.2441520246241059f),Quaternion.Euler(0,-29.959857877816034f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(26.130565055243046f,0f,0.2441520246241059f);
skate1.transform.rotation = Quaternion.Euler(0,121.96521016077394f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(26.130565055243046f,0f,0.2441520246241059f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3457288736793318f);
moveline1 = Instantiate(moveline,new Vector3(26.130565055243046f,0f,0.2441520246241059f),Quaternion.Euler(0,-150.04014212218397f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame487 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(23.69129460403991f,0f,-0.22202639152863912f);
skate0.transform.rotation = Quaternion.Euler(0,56.17267700505089f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(23.69129460403991f,0f,-0.22202639152863912f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3495039186832307f);
moveline0 = Instantiate(moveline,new Vector3(23.69129460403991f,0f,-0.22202639152863912f),Quaternion.Euler(0,-31.96521016077392f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(26.191294604039904f,0f,0.22202639152863912f);
skate1.transform.rotation = Quaternion.Euler(0,123.8273229949491f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(26.191294604039904f,0f,0.22202639152863912f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3495039186832307f);
moveline1 = Instantiate(moveline,new Vector3(26.191294604039904f,0f,0.22202639152863912f),Quaternion.Euler(0,-148.03478983922608f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame488 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(23.75103006028504f,0f,-0.19599931341488147f);
skate0.transform.rotation = Quaternion.Euler(0,54.45380361965842f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(23.75103006028504f,0f,-0.19599931341488147f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3540901195981845f);
moveline0 = Instantiate(moveline,new Vector3(23.75103006028504f,0f,-0.19599931341488147f),Quaternion.Euler(0,-33.827322994949114f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(26.251030060285032f,0f,0.19599931341488147f);
skate1.transform.rotation = Quaternion.Euler(0,125.54619638034157f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(26.251030060285032f,0f,0.19599931341488147f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3540901195981845f);
moveline1 = Instantiate(moveline,new Vector3(26.251030060285032f,0f,0.19599931341488147f),Quaternion.Euler(0,-146.17267700505093f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame489 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(23.809727375153233f,0f,-0.16609164890643835f);
skate0.transform.rotation = Quaternion.Euler(0,52.87816968304866f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(23.809727375153233f,0f,-0.16609164890643835f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.359481335802509f);
moveline0 = Instantiate(moveline,new Vector3(23.809727375153233f,0f,-0.16609164890643835f),Quaternion.Euler(0,-35.54619638034157f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(26.309727375153226f,0f,0.16609164890643835f);
skate1.transform.rotation = Quaternion.Euler(0,127.12183031695133f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(26.309727375153226f,0f,0.16609164890643835f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.359481335802509f);
moveline1 = Instantiate(moveline,new Vector3(26.309727375153226f,0f,0.16609164890643835f),Quaternion.Euler(0,-144.45380361965843f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame490 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(23.867346990321195f,0f,-0.1323214378081243f);
skate0.transform.rotation = Quaternion.Euler(0,51.4457751952216f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(23.867346990321195f,0f,-0.1323214378081243f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3656720482121378f);
moveline0 = Instantiate(moveline,new Vector3(23.867346990321195f,0f,-0.1323214378081243f),Quaternion.Euler(0,-37.12183031695132f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(26.367346990321188f,0f,0.1323214378081243f);
skate1.transform.rotation = Quaternion.Euler(0,128.5542248047784f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(26.367346990321188f,0f,0.1323214378081243f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3656720482121378f);
moveline1 = Instantiate(moveline,new Vector3(26.367346990321188f,0f,0.1323214378081243f),Quaternion.Euler(0,-142.87816968304867f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame491 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(23.92385365009776f,0f,-0.09470359055961057f);
skate0.transform.rotation = Quaternion.Euler(0,50.15662015617725f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(23.92385365009776f,0f,-0.09470359055961057f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3726575863638988f);
moveline0 = Instantiate(moveline,new Vector3(23.92385365009776f,0f,-0.09470359055961057f),Quaternion.Euler(0,-38.554224804778414f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(26.423853650097755f,0f,0.09470359055961057f);
skate1.transform.rotation = Quaternion.Euler(0,129.84337984382276f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(26.423853650097755f,0f,0.09470359055961057f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3726575863638988f);
moveline1 = Instantiate(moveline,new Vector3(26.423853650097755f,0f,0.09470359055961057f),Quaternion.Euler(0,-141.4457751952216f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame492 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(23.979216218446414f,0f,-0.05324961290145277f);
skate0.transform.rotation = Quaternion.Euler(0,49.0107045659156f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(23.979216218446414f,0f,-0.05324961290145277f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3804343665255006f);
moveline0 = Instantiate(moveline,new Vector3(23.979216218446414f,0f,-0.05324961290145277f),Quaternion.Euler(0,-39.84337984382276f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(26.479216218446407f,0f,0.05324961290145277f);
skate1.transform.rotation = Quaternion.Euler(0,130.9892954340844f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(26.479216218446407f,0f,0.05324961290145277f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3804343665255006f);
moveline1 = Instantiate(moveline,new Vector3(26.479216218446407f,0f,0.05324961290145277f),Quaternion.Euler(0,-140.15662015617724f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame493 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(24.033407504625046f,0f,-0.00796736331410209f);
skate0.transform.rotation = Quaternion.Euler(0,48.00802842443666f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(24.033407504625046f,0f,-0.00796736331410209f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3890001418416311f);
moveline0 = Instantiate(moveline,new Vector3(24.033407504625046f,0f,-0.00796736331410209f),Quaternion.Euler(0,-40.9892954340844f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(26.53340750462504f,0f,0.00796736331410209f);
skate1.transform.rotation = Quaternion.Euler(0,131.99197157556335f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(26.53340750462504f,0f,0.00796736331410209f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3890001418416311f);
moveline1 = Instantiate(moveline,new Vector3(26.53340750462504f,0f,0.00796736331410209f),Quaternion.Euler(0,-139.0107045659156f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame494 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(24.086404100681314f,0f,0.04113915921017121f);
skate0.transform.rotation = Quaternion.Euler(0,47.148591731740424f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(24.086404100681314f,0f,0.04113915921017121f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.3983542662817887f);
moveline0 = Instantiate(moveline,new Vector3(24.086404100681314f,0f,0.04113915921017121f),Quaternion.Euler(0,-41.991971575563326f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
skate1.transform.position = new Vector3(26.586404100681307f,0f,-0.04113915921017121f);
skate1.transform.rotation = Quaternion.Euler(0,132.85140826825958f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(26.586404100681307f,0f,-0.04113915921017121f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.3983542662817887f);
moveline1 = Instantiate(moveline,new Vector3(26.586404100681307f,0f,-0.04113915921017121f),Quaternion.Euler(0,-138.00802842443667f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0000000000000002f);
}
}
public class frame495 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(24.138186233585678f,0f,0.09145171393104302f);
skate0.transform.rotation = Quaternion.Euler(0,46.4323944878269f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(24.138186233585678f,0f,0.09145171393104302f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.4084979750130344f);
moveline0 = Instantiate(moveline,new Vector3(24.138186233585678f,0f,0.09145171393104302f),Quaternion.Euler(0,-137.14859173174042f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(26.63818623358567f,0f,-0.09145171393104302f);
skate1.transform.rotation = Quaternion.Euler(0,133.5676055121731f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(26.63818623358567f,0f,-0.09145171393104302f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.4084979750130344f);
moveline1 = Instantiate(moveline,new Vector3(26.63818623358567f,0f,-0.09145171393104302f),Quaternion.Euler(0,-42.851408268259576f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame496 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(24.19119909862158f,0f,0.1430041470556523f);
skate0.transform.rotation = Quaternion.Euler(0,45.85943669269608f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(24.19119909862158f,0f,0.1430041470556523f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.418893556082357f);
moveline0 = Instantiate(moveline,new Vector3(24.19119909862158f,0f,0.1430041470556523f),Quaternion.Euler(0,136.4323944878269f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(26.691199098621574f,0f,-0.1430041470556523f);
skate1.transform.rotation = Quaternion.Euler(0,134.14056330730392f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(26.691199098621574f,0f,-0.1430041470556523f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.418893556082357f);
moveline1 = Instantiate(moveline,new Vector3(26.691199098621574f,0f,-0.1430041470556523f),Quaternion.Euler(0,43.5676055121731f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame497 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(24.242968354676787f,0f,0.19582786280135792f);
skate0.transform.rotation = Quaternion.Euler(0,45.42971834634796f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(24.242968354676787f,0f,0.19582786280135792f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.4295517049538766f);
moveline0 = Instantiate(moveline,new Vector3(24.242968354676787f,0f,0.19582786280135792f),Quaternion.Euler(0,-135.85943669269605f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(26.74296835467678f,0f,-0.19582786280135792f);
skate1.transform.rotation = Quaternion.Euler(0,134.57028165365205f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(26.74296835467678f,0f,-0.19582786280135792f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.4295517049538766f);
moveline1 = Instantiate(moveline,new Vector3(26.74296835467678f,0f,-0.19582786280135792f),Quaternion.Euler(0,-44.14056330730395f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame498 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(24.295990795808354f,0f,0.24995174464937756f);
skate0.transform.rotation = Quaternion.Euler(0,45.14323944878255f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(24.295990795808354f,0f,0.24995174464937756f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.4404831623379764f);
moveline0 = Instantiate(moveline,new Vector3(24.295990795808354f,0f,0.24995174464937756f),Quaternion.Euler(0,135.42971834634795f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(26.795990795808347f,0f,-0.24995174464937756f);
skate1.transform.rotation = Quaternion.Euler(0,134.85676055121746f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(26.795990795808347f,0f,-0.24995174464937756f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.4404831623379764f);
moveline1 = Instantiate(moveline,new Vector3(26.795990795808347f,0f,-0.24995174464937756f),Quaternion.Euler(0,44.57028165365204f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame499 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(24.350272766951292f,0f,0.30540210225602343f);
skate0.transform.rotation = Quaternion.Euler(0,44.999999999999844f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(24.350272766951292f,0f,0.30540210225602343f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.4516987614212395f);
moveline0 = Instantiate(moveline,new Vector3(24.350272766951292f,0f,0.30540210225602343f),Quaternion.Euler(0,135.14323944878254f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(26.850272766951285f,0f,-0.30540210225602343f);
skate1.transform.rotation = Quaternion.Euler(0,135.00000000000017f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(26.850272766951285f,0f,-0.30540210225602343f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.4516987614212395f);
moveline1 = Instantiate(moveline,new Vector3(26.850272766951285f,0f,-0.30540210225602343f),Quaternion.Euler(0,44.856760551217455f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
public class frame500 : frame
{
public void visualize()
{
skate0.transform.position = new Vector3(24.40581742877492f,0f,0.36220264326173746f);
skate0.transform.rotation = Quaternion.Euler(0,44.999999999999844f, 0);
Destroy(forceline0);
Destroy(moveline0);
forceline0 = Instantiate(forceline,new Vector3(24.40581742877492f,0f,0.36220264326173746f),Quaternion.Euler(0,0.0f, 0));
forceline0.transform.localScale = new Vector3(0f,0f,1.4632094846647177f);
moveline0 = Instantiate(moveline,new Vector3(24.40581742877492f,0f,0.36220264326173746f),Quaternion.Euler(0,134.99999999999983f, 0));
moveline0.transform.localScale = new Vector3(0f,0f,1.0f);
skate1.transform.position = new Vector3(26.905817428774913f,0f,-0.36220264326173746f);
skate1.transform.rotation = Quaternion.Euler(0,135.00000000000017f, 0);
Destroy(forceline1);
Destroy(moveline1);
forceline1 = Instantiate(forceline,new Vector3(26.905817428774913f,0f,-0.36220264326173746f),Quaternion.Euler(0,0.0f, 0));
forceline1.transform.localScale = new Vector3(0f,0f,-1.4632094846647177f);
moveline1 = Instantiate(moveline,new Vector3(26.905817428774913f,0f,-0.36220264326173746f),Quaternion.Euler(0,45.000000000000156f, 0));
moveline1.transform.localScale = new Vector3(0f,0f,1.0f);
}
}
Vector3[] camerapos = {new Vector3(1.25f,5f,0f), new Vector3(1.2498214285714284f,5.0f,0.0f), new Vector3(1.2494642550133035f,5.000000051020408f,0.0f), new Vector3(1.2489284314846407f,5.000000457710406f,0.0f), new Vector3(1.2482139201591957f,5.000001822016043f,0.0f), new Vector3(1.2473207340268835f,5.00000502854314f,0.0f), new Vector3(1.2462489913895194f,5.000011222779933f,0.0f), new Vector3(1.2449989840549986f,5.000021782419486f,0.0f), new Vector3(1.243571259139293f,5.000038282144067f,0.0f), new Vector3(1.241966714226752f,5.000062452389169f,0.0f), new Vector3(1.2401867054036098f,5.00009613279839f,0.0f), new Vector3(1.2382331673555047f,5.000141221313792f,0.0f), new Vector3(1.23610874429703f,5.000199620117917f,0.0f), new Vector3(1.2338169299719737f,5.000273179947374f,0.0f), new Vector3(1.231362214322926f,5.000363644622508f,0.0f), new Vector3(1.2287502336792642f,5.000472597966345f,0.0f), new Vector3(1.2259879204610344f,5.000601415596011f,0.0f), new Vector3(1.223083647459386f,5.0007512243329435f,0.0f), new Vector3(1.2200473607591271f,5.000922872161829f,0.0f), new Vector3(1.21689069435511f,5.001116911737468f,0.0f), new Vector3(1.2136270585350282f,5.001333600359639f,0.0f), new Vector3(1.2102716932251063f,5.00157291907932f,0.0f), new Vector3(1.2068416768054422f,5.0018346131464275f,0.0f), new Vector3(1.2033558804955657f,5.00211825535549f,0.0f), new Vector3(1.1998348583965162f,5.002423333007993f,0.0f), new Vector3(1.196300663768608f,5.002749358228397f,0.0f), new Vector3(1.1927180789282628f,5.003096000309107f,0.0f), new Vector3(1.1889801516914502f,5.003360007915869f,0.0f), new Vector3(1.1849849058238622f,5.003528257328338f,0.0f), new Vector3(1.1806355901555259f,5.003591363631653f,0.0f), new Vector3(1.1758408460820688f,5.003543950490806f,0.0f), new Vector3(1.170514802877145f,5.003385114270276f,0.0f), new Vector3(1.1658004092373178f,5.003119053043471f,0.0f), new Vector3(1.1617725167668964f,5.002755833229146f,0.0f), new Vector3(1.158500544942504f,5.002312268015486f,0.0f), new Vector3(1.1560485848745403f,5.001812882549357f,0.0f), new Vector3(1.1544755324696057f,5.001290941216488f,0.0f), new Vector3(1.1538352438922563f,5.000789512329622f,0.0f), new Vector3(1.154176706802058f,5.000362545262269f,0.0f), new Vector3(1.1555442214255285f,5.00007593458159f,0.0f), new Vector3(1.1579775861005364f,5.00000854509843f,0.0f), new Vector3(1.16151228249405f,5.000253171014906f,0.0f), new Vector3(1.1661796562360136f,5.000917401565585f,0.0f), new Vector3(1.1720070892279397f,5.002124364787814f,0.0f), new Vector3(1.1790181603717114f,5.004013320415535f,0.0f), new Vector3(1.187232791920906f,5.006740072495632f,0.0f), new Vector3(1.1966673790838405f,5.010477172340006f,0.0f), new Vector3(1.2073349009059133f,5.015413883050769f,0.0f), new Vector3(1.2192450108310275f,5.021755878324841f,0.0f), new Vector3(1.2324041056911124f,5.029724650815867f,0.0f), new Vector3(1.2468153722028876f,5.039556609270939f,0.0f), new Vector3(1.2624788103663536f,5.051501849213618f,0.0f), new Vector3(1.2793912334647903f,5.064452397332033f,0.0f), new Vector3(1.297546244666268f,5.07823145590244f,0.0f), new Vector3(1.3169341905268843f,5.09266908209128f,0.0f), new Vector3(1.3375420920012404f,5.10760124428168f,0.0f), new Vector3(1.3569464330701737f,5.122868999842837f,0.0f), new Vector3(1.3775344122909523f,5.140760228760899f,0.0f), new Vector3(1.3992824507616934f,5.1589563824996345f,0.0f), new Vector3(1.4207944709598548f,5.17728707927572f,0.0f), new Vector3(1.4434078228765221f,5.196775288756517f,0.0f), new Vector3(1.4670870248447268f,5.216172628063754f,0.0f), new Vector3(1.4905307573887512f,5.23530931038382f,0.0f), new Vector3(1.5149562414199271f,5.255404704599621f,0.0f), new Vector3(1.540314489278688f,5.275005147149231f,0.0f), new Vector3(1.565450717540456f,5.293943275466973f,0.0f), new Vector3(1.5914069575586522f,5.313628323109348f,0.0f), new Vector3(1.6181191182228776f,5.332415094683655f,0.0f), new Vector3(1.645517780056509f,5.350144941612606f,0.0f), new Vector3(1.6735280914552368f,5.366667887533286f,0.0f), new Vector3(1.7020697019854316f,5.38184394445246f,0.0f), new Vector3(1.731056740920747f,5.3955445549597245f,0.0f), new Vector3(1.7603978496568107f,5.407654137671449f,0.0f), new Vector3(1.7899962770236495f,5.418071707502077f,0.0f), new Vector3(1.819750046786956f,5.426712536375977f,0.0f), new Vector3(1.8495522067626997f,5.433509813731252f,0.0f), new Vector3(1.8792911689324303f,5.438416259823006f,0.0f), new Vector3(1.9088600355144092f,5.436906790658147f,0.0f), new Vector3(1.9387008719553476f,5.429021087842687f,0.0f), new Vector3(1.968173130218203f,5.420366194843636f,0.0f), new Vector3(1.9981051479678815f,5.405607104749103f,0.0f), new Vector3(2.028582590354385f,5.3902099219741695f,0.0f), new Vector3(2.058434485679461f,5.374179965349243f,0.0f), new Vector3(2.088986534733826f,5.352733725472378f,0.0f), new Vector3(2.120307900275154f,5.3309159180667445f,0.0f), new Vector3(2.1507961219456466f,5.308767499365664f,0.0f), new Vector3(2.180392570170834f,5.286340419137969f,0.0f), new Vector3(2.210934383099795f,5.259844455206505f,0.0f), new Vector3(2.242470288580482f,5.233558110441311f,0.0f), new Vector3(2.2729680526842353f,5.207607027892885f,0.0f), new Vector3(2.3023881170877547f,5.182137965891093f,0.0f), new Vector3(2.3329211368826686f,5.157320373200311f,0.0f), new Vector3(2.3623100652496665f,5.133347746786092f,0.0f), new Vector3(2.392870275786683f,5.110438732250061f,0.0f), new Vector3(2.4222357962013357f,5.088837920173246f,0.0f), new Vector3(2.4528157797678927f,5.068816285213425f,0.0f), new Vector3(2.4846264954659905f,5.050671209466232f,0.0f), new Vector3(2.515214991425394f,5.03472602812789f,0.0f), new Vector3(2.5470566724611565f,5.021320918242581f,0.0f), new Vector3(2.5801578835082895f,5.010840290155222f,0.0f), new Vector3(2.6145217852361124f,5.003677212864304f,0.0f), new Vector3(2.650148377644626f,5.00024293324261f,0.0f), new Vector3(2.684515440041769f,5.00080235331467f,0.0f), new Vector3(2.720135687515271f,5.005518016314778f,0.0f), new Vector3(2.75699954396947f,5.014176802329501f,0.0f), new Vector3(2.7936613261702563f,5.026457417029787f,0.0f), new Vector3(2.831537571522947f,5.042600139612393f,0.0f), new Vector3(2.869199996055929f,5.06195333328571f,0.0f), new Vector3(2.9080337027589294f,5.084982974055853f,0.0f), new Vector3(2.948011500889846f,5.110789777416525f,0.0f), new Vector3(2.9877617638594325f,5.139041530520598f,0.0f), new Vector3(3.0285897265292525f,5.170540385300689f,0.0f), new Vector3(3.070455830576007f,5.204030653981356f,0.0f), new Vector3(3.1133160271744877f,5.23918089163801f,0.0f), new Vector3(3.157121588476742f,5.275666366409284f,0.0f), new Vector3(3.2018189232243026f,5.313169993718904f,0.0f), new Vector3(3.247349401842698f,5.351383330843124f,0.0f), new Vector3(3.293649196948057f,5.390007646766876f,0.0f), new Vector3(3.3406491457827046f,5.428755079882761f,0.0f), new Vector3(3.3882746416787803f,5.46734989303155f,0.0f), new Vector3(3.4364455622116807f,5.505529831735633f,0.0f), new Vector3(3.485076242231404f,5.543047587309811f,0.0f), new Vector3(3.5340755004292106f,5.579672361919618f,0.0f), new Vector3(3.583346728485977f,5.615191527674408f,0.0f), new Vector3(3.632788052130495f,5.649412366581656f,0.0f), new Vector3(3.6822925735810266f,5.682163872760871f,0.0f), new Vector3(3.73174870481912f,5.713298592857934f,0.0f), new Vector3(3.7810494936607464f,5.737081789223868f,0.0f), new Vector3(3.8300929638715973f,5.753215773320326f,0.0f), new Vector3(3.8787823642817f,5.76152053898623f,0.0f), new Vector3(3.9270263362866817f,5.761926936053263f,0.0f), new Vector3(3.974739009160197f,5.754471562371172f,0.0f), new Vector3(4.021840032468615f,5.739293457569906f,0.0f), new Vector3(4.068254554607629f,5.716632664635299f,0.0f), new Vector3(4.113913156100612f,5.686830716271799f,0.0f), new Vector3(4.158751745837168f,5.65033309503055f,0.0f), new Vector3(4.202711427910693f,5.6076937019975714f,0.0f), new Vector3(4.245738346156634f,5.559581340073206f,0.0f), new Vector3(4.287783512915424f,5.5119038967616785f,0.0f), new Vector3(4.328802627960545f,5.4647889261267295f,0.0f), new Vector3(4.370887593057203f,5.413894383606266f,0.0f), new Vector3(4.4118712264353555f,5.36436580452688f,0.0f), new Vector3(4.451722182465058f,5.316449836344425f,0.0f), new Vector3(4.492733197744722f,5.270426610456472f,0.0f), new Vector3(4.532573329745194f,5.226610825621333f,0.0f), new Vector3(4.573617022151089f,5.185337031746313f,0.0f), new Vector3(4.613469785158114f,5.147008548795147f,0.0f), new Vector3(4.654555482824278f,5.112018857568236f,0.0f), new Vector3(4.694433454663729f,5.080853208788376f,0.0f), new Vector3(4.735560411438151f,5.053972847711394f,0.0f), new Vector3(4.7779395398642635f,5.031916659334635f,0.0f), new Vector3(4.8215708399420665f,5.015214751514588f,0.0f), new Vector3(4.865033690893806f,5.004779540689417f,0.0f), new Vector3(4.909739129948586f,5.000214649290511f,0.0f), new Vector3(4.954260558776618f,5.001495356252217f,0.0f), new Vector3(4.998590394498072f,5.008497065599471f,0.0f), new Vector3(5.0441237906249485f,5.021268244464407f,0.0f), new Vector3(5.090840824903671f,5.039288012768096f,0.0f), new Vector3(5.137345431478565f,5.062136137967791f,0.0f), new Vector3(5.184982715401909f,5.090219484747779f,0.0f), new Vector3(5.23372133104376f,5.122548292946184f,0.0f), new Vector3(5.283525796737147f,5.158685209235588f,0.0f), new Vector3(5.334356314144204f,5.198196725204189f,0.0f), new Vector3(5.386168583038411f,5.240655359336888f,0.0f), new Vector3(5.438913615760203f,5.285641673743365f,0.0f), new Vector3(5.492537556145025f,5.3327461437609855f,0.0f), new Vector3(5.546981508286275f,5.381570905873468f,0.0f), new Vector3(5.602181381073554f,5.431731413681766f,0.0f), new Vector3(5.658067755030239f,5.48285803322653f,0.0f), new Vector3(5.7145657785520205f,5.53459760817437f,0.0f), new Vector3(5.771595101205269f,5.586615022661632f,0.0f), new Vector3(5.829069852263638f,5.6385947853511915f,0.0f), new Vector3(5.886898673122755f,5.690242652879285f,0.0f), new Vector3(5.944984812612648f,5.741287304685126f,0.0f), new Vector3(6.003226294499008f,5.79148207451601f,0.0f), new Vector3(6.061516166597805f,5.8406067369356816f,0.0f), new Vector3(6.11974284089059f,5.888469340156551f,0.0f), new Vector3(6.1777994195956225f,5.9287588761762695f,0.0f), new Vector3(6.2355840284416955f,5.961051985208188f,0.0f), new Vector3(6.293000059109685f,5.98504231979139f,0.0f), new Vector3(6.349956330290852f,6.000530366307783f,0.0f), new Vector3(6.406367176835194f,6.007415020037165f,0.0f), new Vector3(6.462152476318108f,6.005686937350043f,0.0f), new Vector3(6.517237622071733f,5.995423674713356f,0.0f), new Vector3(6.571553451338396f,5.976786625314981f,0.0f), new Vector3(6.625036136734223f,5.950019774419496f,0.0f), new Vector3(6.6776270486847435f,5.915450309430676f,0.0f), new Vector3(6.729272595931491f,5.873491135936832f,0.0f), new Vector3(6.779924050626512f,5.824645362393618f,0.0f), new Vector3(6.829537363944598f,5.769512818188807f,0.0f), new Vector3(6.878072977562451f,5.708798655433463f,0.0f), new Vector3(6.925495635788909f,5.643324044007801f,0.0f), new Vector3(6.9717742025874525f,5.574038888635087f,0.0f), new Vector3(7.019224051556014f,5.50203635832814f,0.0f), new Vector3(7.065528808376204f,5.432777302382803f,0.0f), new Vector3(7.113048028348297f,5.366594001107753f,0.0f), new Vector3(7.159400659377365f,5.30403818557547f,0.0f), new Vector3(7.20699689938713f,5.2455340331152955f,0.0f), new Vector3(7.253407893359534f,5.191731071915153f,0.0f), new Vector3(7.301078417343309f,5.143157633033486f,0.0f), new Vector3(7.350011632007773f,5.100528348704606f,0.0f), new Vector3(7.400207537352928f,5.064504766203041f,0.0f), new Vector3(7.450252907249945f,5.036797423773099f,0.0f), new Vector3(7.500138590883242f,5.01670948973938f,0.0f), new Vector3(7.5512678834972355f,5.004402792707687f,0.0f), new Vector3(7.602219491422477f,5.000020764836066f,0.0f), new Vector3(7.654385562499622f,5.003301508470145f,0.0f), new Vector3(7.707746323699132f,5.013977796404773f,0.0f), new Vector3(7.7609045552252205f,5.031573284416231f,0.0f), new Vector3(7.815206878179225f,5.056256297037685f,0.0f), new Vector3(7.870622156524625f,5.087174193691494f,0.0f), new Vector3(7.927115134570258f,5.123796418927634f,0.0f), new Vector3(7.984646253992826f,5.165588759806306f,0.0f), new Vector3(8.04317146596712f,5.212018054286014f,0.0f), new Vector3(8.102642042645186f,5.262556504994363f,0.0f), new Vector3(8.16300439276856f,5.316685566645075f,0.0f), new Vector3(8.224199886762769f,5.373899408586154f,0.0f), new Vector3(8.28616469724394f,5.433707979787038f,0.0f), new Vector3(8.3488296614544f,5.495639721653717f,0.0f), new Vector3(8.41212017272629f,5.55924398484379f,0.0f), new Vector3(8.475956108635003f,5.624093210678397f,0.0f), new Vector3(8.54025180403054f,5.689784936994992f,0.0f), new Vector3(8.604916077604159f,5.755943683579552f,0.0f), new Vector3(8.669852321036739f,5.822222764799618f,0.0f), new Vector3(8.73495866005707f,5.888306067716203f,0.0f), new Vector3(8.800128196883414f,5.953909823588065f,0.0f), new Vector3(8.86524934349732f,6.018784389925564f,0.0f), new Vector3(8.93021514771476f,6.076214903387227f,0.0f), new Vector3(8.994923633301424f,6.125653344633995f,0.0f), new Vector3(9.05927804908734f,6.166675194585274f,0.0f), new Vector3(9.123187036468135f,6.198966150368571f,0.0f), new Vector3(9.186564724717464f,6.22231073511971f,0.0f), new Vector3(9.249330763401694f,6.236582770587484f,0.0f), new Vector3(9.31141030091652f,6.241737660320252f,0.0f), new Vector3(9.372733917785318f,6.23780643018125f,0.0f), new Vector3(9.433237522897684f,6.224891484758721f,0.0f), new Vector3(9.492862220347025f,6.203164058049302f,0.0f), new Vector3(9.551554153968777f,6.172863361330224f,0.0f), new Vector3(9.60926433610338f,6.134297458022242f,0.0f), new Vector3(9.665948466524313f,6.087845922502298f,0.0f), new Vector3(9.72156674689371f,6.033964364908117f,0.0f), new Vector3(9.7760836955446f,5.973190923775574f,0.0f), new Vector3(9.82946796684704f,5.906154838082505f,0.0f), new Vector3(9.88169217889952f,5.833587202724089f,0.0f), new Vector3(9.932732752800153f,5.7563339759222f,0.0f), new Vector3(9.982569766295363f,5.67537122824483f,0.0f), new Vector3(10.031186824176832f,5.591822479776707f,0.0f), new Vector3(10.08103681671744f,5.506977737501503f,0.0f), new Vector3(10.13212939736109f,5.426320263782939f,0.0f), new Vector3(10.182060488959443f,5.350444609806155f,0.0f), new Vector3(10.23324375220949f,5.279882786319933f,0.0f), new Vector3(10.285679187111228f,5.215471373422037f,0.0f), new Vector3(10.337995003885748f,5.160062171013196f,0.0f), new Vector3(10.391553408763308f,5.112454340491353f,0.0f), new Vector3(10.444973159596685f,5.0736983667534155f,0.0f), new Vector3(10.499612866043798f,5.042895542942681f,0.0f), new Vector3(10.554095650426575f,5.020668412444476f,0.0f), new Vector3(10.6097620729612f,5.006410302437124f,0.0f), new Vector3(10.666588554745786f,5.000307484160944f,0.0f), new Vector3(10.72454771387882f,5.001913441881538f,0.0f), new Vector3(10.783608204730363f,5.010752778871486f,0.0f), new Vector3(10.843734545633442f,5.026326414303824f,0.0f), new Vector3(10.90488693825019f,5.048117131294419f,0.0f), new Vector3(10.967021082354087f,5.075595260468887f,0.0f), new Vector3(11.030087990285573f,5.108224310615977f,0.0f), new Vector3(11.094033805880084f,5.145466394877914f,0.0f), new Vector3(11.158799633231027f,5.1867873422903585f,0.0f), new Vector3(11.224321381227998f,5.231661425642522f,0.0f), new Vector3(11.290529630394374f,5.279575673941691f,0.0f), new Vector3(11.357349529125848f,5.3300337688346024f,0.0f), new Vector3(11.424700726988789f,5.382559547960676f,0.0f), new Vector3(11.492497353256852f,5.436700154193568f,0.0f), new Vector3(11.56064804932566f,5.492028878606046f,0.0f), new Vector3(11.629056064025246f,5.54814774776329f,0.0f), new Vector3(11.697619421121296f,5.60468990382239f,0.0f), new Vector3(11.766231168429787f,5.661321820138277f,0.0f), new Vector3(11.83477971793226f,5.717745386813849f,0.0f), new Vector3(11.903158171846986f,5.7679935107634615f,0.0f), new Vector3(11.97126465590275f,5.811411189885785f,0.0f), new Vector3(12.039002561780432f,5.8474853846676265f,0.0f), new Vector3(12.10628070817129f,5.875830907221389f,0.0f), new Vector3(12.173013429925323f,5.8961781689818205f,0.0f), new Vector3(12.23912060461793f,5.90836287060576f,0.0f), new Vector3(12.304527625581247f,5.9123176539968565f,0.0f), new Vector3(12.369165330057601f,5.908065706379793f,0.0f), new Vector3(12.43296989066312f,5.895716298520279f,0.0f), new Vector3(12.495882677823332f,5.875462245180637f,0.0f), new Vector3(12.557850100279772f,5.847579289501868f,0.0f), new Vector3(12.618823430184484f,5.8124274292128595f,0.0f), new Vector3(12.678758618712262f,5.770454216753705f,0.0f), new Vector3(12.737616107539807f,5.722200072485577f,0.0f), new Vector3(12.795360640975957f,5.668305643804717f,0.0f), new Vector3(12.85196108298419f,5.609521214743069f,0.0f), new Vector3(12.907390242822405f,5.546718109164791f,0.0f), new Vector3(12.961624712538256f,5.480901921045414f,0.0f), new Vector3(13.014644719102204f,5.413227229001229f,0.0f), new Vector3(13.066433993534613f,5.345013188203324f,0.0f), new Vector3(13.117051995647902f,5.27775902113494f,0.0f), new Vector3(13.168923182837549f,5.215983866846702f,0.0f), new Vector3(13.219603386841904f,5.160469886318183f,0.0f), new Vector3(13.271546281526945f,5.111876230956761f,0.0f), new Vector3(13.32475186689268f,5.071030651792174f,0.0f), new Vector3(13.377808032653832f,5.039770101171509f,0.0f), new Vector3(13.432117383491343f,5.017391769592249f,0.0f), new Vector3(13.486257770711825f,5.004271472188146f,0.0f), new Vector3(13.541628890063848f,5.000002128620565f,0.0f), new Vector3(13.596812182927659f,5.0045009331510455f,0.0f), new Vector3(13.653190165913834f,5.017649763983975f,0.0f), new Vector3(13.710739431070028f,5.038916885930026f,0.0f), new Vector3(13.769432787654138f,5.06774784065699f,0.0f), new Vector3(13.829239099629643f,5.1035701711448205f,0.0f), new Vector3(13.89012311130538f,5.145800182640911f,0.0f), new Vector3(13.952045264358052f,5.1938493859088535f,0.0f), new Vector3(14.01496150996245f,5.247130456395461f,0.0f), new Vector3(14.078823120270624f,5.305062606710152f,0.0f), new Vector3(14.143576504024102f,5.3670763282942335f,0.0f), new Vector3(14.209163031648416f,5.432617507164606f,0.0f), new Vector3(14.275518875759692f,5.501150956076003f,0.0f), new Vector3(14.342574873600258f,5.5721634310485815f,0.0f), new Vector3(14.410256418502252f,5.645166214896897f,0.0f), new Vector3(14.47848338804107f,5.719697355852665f,0.0f), new Vector3(14.547170117066711f,5.79532364757814f,0.0f), new Vector3(14.616225424270436f,5.871642429783722f,0.0f), new Vector3(14.685552701333119f,5.948283278044034f,0.0f), new Vector3(14.755050073983554f,6.024909638695988f,0.0f), new Vector3(14.824610644440003f,6.101220451017826f,0.0f), new Vector3(14.894122824684015f,6.1769517850469f,0.0f), new Vector3(14.963479662531558f,6.245024394401794f,0.0f), new Vector3(15.032579181748329f,6.304866972056561f,0.0f), new Vector3(15.10132463116435f,6.356030825553395f,0.0f), new Vector3(15.169624652175248f,6.398175447333172f,0.0f), new Vector3(15.237393374054681f,6.431056071556647f,0.0f), new Vector3(15.304550446369019f,6.454513134216351f,0.0f), new Vector3(15.37102101751395f,6.46846353816405f,0.0f), new Vector3(15.436735668012851f,6.472893628327443f,0.0f), new Vector3(15.501630306755324f,6.467853797604471f,0.0f), new Vector3(15.565646037834767f,6.453454666146528f,0.0f), new Vector3(15.628729005086626f,6.429864803212796f,0.0f), new Vector3(15.690830220851332f,6.397309989857436f,0.0f), new Vector3(15.751905384902372f,6.356074051370469f,0.0f), new Vector3(15.811914698901873f,6.306501319793459f,0.0f), new Vector3(15.870822681182869f,6.249000817933248f,0.0f), new Vector3(15.928597986115413f,6.184052285430874f,0.0f), new Vector3(15.985213231797996f,6.112214191766946f,0.0f), new Vector3(16.040644839328735f,6.034133895872329f,0.0f), new Vector3(16.09487288645405f,5.950560109685643f,0.0f), new Vector3(16.147880977965624f,5.8623577918791305f,0.0f), new Vector3(16.19965613481806f,5.770525520781359f,0.0f), new Vector3(16.250188703567456f,5.67621524784531f,0.0f), new Vector3(16.30197025725182f,5.580754082333841f,0.0f), new Vector3(16.355003982587878f,5.48987538956655f,0.0f), new Vector3(16.409289879575624f,5.4042428523775135f,0.0f), new Vector3(16.46348241078927f,5.327529599152709f,0.0f), new Vector3(16.517571712381397f,5.258107454572244f,0.0f), new Vector3(16.57289394863266f,5.196303970864985f,0.0f), new Vector3(16.628093627979645f,5.143535042195228f,0.0f), new Vector3(16.68449686773205f,5.098633221244508f,0.0f), new Vector3(16.742083745636307f,5.062595406484719f,0.0f), new Vector3(16.799521278214826f,5.035097968100856f,0.0f), new Vector3(16.858091488141795f,5.015404894483246f,0.0f), new Vector3(16.91776302978727f,5.003853848789568f,0.0f), new Vector3(16.978500421484284f,5.000001741929805f,0.0f), new Vector3(17.040263864894964f,5.003373388258843f,0.0f), new Vector3(17.103009059792797f,5.01346703667716f,0.0f), new Vector3(17.166687018518214f,5.029760388426111f,0.0f), new Vector3(17.23124388490666f,5.051716862093643f,0.0f), new Vector3(17.296620763051536f,5.078791889159801f,0.0f), new Vector3(17.36275356184244f,5.110439058729072f,0.0f), new Vector3(17.42957286180275f,5.146115972308013f,0.0f), new Vector3(17.497003811328156f,5.185289713284767f,0.0f), new Vector3(17.56496605998503f,5.227441876797051f,0.0f), new Vector3(17.633373737047023f,5.272073140866739f,0.0f), new Vector3(17.702135483909768f,5.318707387299419f,0.0f), new Vector3(17.771154549403285f,5.3668954003427825f,0.0f), new Vector3(17.84032895729327f,5.416218182824726f,0.0f), new Vector3(17.909551755395693f,5.466289934412771f,0.0f), new Vector3(17.978711355692102f,5.5167607360407525f,0.0f), new Vector3(18.04770086040076f,5.562302224996598f,0.0f), new Vector3(18.11641839525046f,5.602143246123851f,0.0f), new Vector3(18.184767351922076f,5.635670848514953f,0.0f), new Vector3(18.25265654910687f,5.662415703573942f,0.0f), new Vector3(18.320000321654838f,5.682039145161619f,0.0f), new Vector3(18.386718547141378f,5.694322071026705f,0.0f), new Vector3(18.45273661889863f,5.699155826883144f,0.0f), new Vector3(18.517985374168916f,5.696535124960469f,0.0f), new Vector3(18.582400985568366f,5.686553012452191f,0.0f), new Vector3(18.645924823522513f,5.669397890165749f,0.0f), new Vector3(18.708503296772886f,5.645352578537052f,0.0f), new Vector3(18.770087677471533f,5.614795429323559f,0.0f), new Vector3(18.830633916793246f,5.578203479696682f,0.0f), new Vector3(18.890102456414724f,5.536157633816246f,0.0f), new Vector3(18.94845804064481f,5.489349826864562f,0.0f), new Vector3(19.005669533446977f,5.438592067666215f,0.0f), new Vector3(19.061709744079124f,5.384827155819226f,0.0f), new Vector3(19.116555264588907f,5.329140712894354f,0.0f), new Vector3(19.170186321946787f,5.272773938916128f,0.0f), new Vector3(19.222586647173127f,5.217136191431137f,0.0f), new Vector3(19.27374336341877f,5.163816079906622f,0.0f), new Vector3(19.32615326474077f,5.114589286850194f,0.0f), new Vector3(19.379822696074143f,5.073132693604731f,0.0f), new Vector3(19.434754818088205f,5.040211183730677f,0.0f), new Vector3(19.490949630782957f,5.016600929275573f,0.0f), new Vector3(19.546974355328953f,5.003382136535479f,0.0f), new Vector3(19.60281865756139f,5.000164699176878f,0.0f), new Vector3(19.659906568774524f,5.007060768670968f,0.0f), new Vector3(19.718225212119197f,5.023704260726805f,0.0f), new Vector3(19.776333326927013f,5.049529396712902f,0.0f), new Vector3(19.835636131857193f,5.08472596212202f,0.0f), new Vector3(19.896110218957393f,5.128239223692036f,0.0f), new Vector3(19.957728397485507f,5.179417477413414f,0.0f), new Vector3(20.020459531405017f,5.237602273302568f,0.0f), new Vector3(20.08426836502476f,5.302136040031876f,0.0f), new Vector3(20.149115340021435f,5.37236877935798f,0.0f), new Vector3(20.21495640756984f,5.447663768596359f,0.0f), new Vector3(20.28174283982202f,5.527402287500132f,0.0f), new Vector3(20.349421045519502f,5.610987444223328f,0.0f), new Vector3(20.41793239508782f,5.697847213523622f,0.0f), new Vector3(20.487213061143102f,5.7874368211243725f,0.0f), new Vector3(20.557193880927674f,5.879240614515333f,0.0f), new Vector3(20.627800247773674f,5.9727735560691615f,0.0f), new Vector3(20.698952039256497f,6.06758246260938f,0.0f), new Vector3(20.770563590226143f,6.163247099374359f,0.0f), new Vector3(20.84254371937387f,6.259381217923346f,0.0f), new Vector3(20.91479581838056f,6.3556336085325436f,0.0f), new Vector3(20.987218012975003f,6.451689219092905f,0.0f), new Vector3(21.05970340537546f,6.547270375076769f,0.0f), new Vector3(21.132140407563476f,6.642138119103977f,0.0f), new Vector3(21.204422067355026f,6.728440725034929f,0.0f), new Vector3(21.2764464085158f,6.8056684277914545f,0.0f), new Vector3(21.348116679875826f,6.873420512532908f,0.0f), new Vector3(21.41934152283073f,6.931390996940165f,0.0f), new Vector3(21.49003506665417f,6.979356286632793f,0.0f), new Vector3(21.560116960912513f,7.017164633494803f,0.0f), new Vector3(21.62951235400145f,7.044727236699697f,0.0f), new Vector3(21.698151826444356f,7.062010845140411f,0.0f), new Vector3(21.765971287130835f,7.0690317433201795f,0.0f), new Vector3(21.832911840154285f,7.065851028090497f,0.0f), new Vector3(21.89891962935015f,7.052571109750728f,0.0f), new Vector3(21.963945667058862f,7.029333397562177f,0.0f), new Vector3(22.027945653053905f,6.996317156766636f,0.0f), new Vector3(22.090879788997412f,6.953739552096567f,0.0f), new Vector3(22.152712593222414f,6.901856922009871f,0.0f), new Vector3(22.213412720098965f,6.840967358972117f,0.0f), new Vector3(22.272952787725554f,6.771414704417259f,0.0f), new Vector3(22.331309217200296f,6.693594102619924f,0.0f), new Vector3(22.388462086269616f,6.607959295120694f,0.0f), new Vector3(22.444394999725198f,6.515031875089739f,0.0f), new Vector3(22.49909497852164f,6.415412755988488f,0.0f), new Vector3(22.55255236921504f,6.309796135356887f,0.0f), new Vector3(22.60476077497347f,6.198986242675823f,0.0f), new Vector3(22.65571700908021f,6.0839171340129035f,0.0f), new Vector3(22.70792541483864f,5.96567571062938f,0.0f), new Vector3(22.760097517066995f,5.8552665588679655f,0.0f), new Vector3(22.81351220739839f,5.75013075587042f,0.0f), new Vector3(22.866871124003396f,5.652863708472201f,0.0f), new Vector3(22.92016475851764f,5.561179437325669f,0.0f), new Vector3(22.97466195343731f,5.475369269740031f,0.0f), new Vector3(23.03034278650882f,5.3975928239249855f,0.0f), new Vector3(23.085931394633825f,5.327678760009251f,0.0f), new Vector3(23.14265268010728f,5.2638627679737375f,0.0f), new Vector3(23.20047529729924f,5.207805431482705f,0.0f), new Vector3(23.259363764542734f,5.159249616367341f,0.0f), new Vector3(23.319278283499898f,5.1179054972194935f,0.0f), new Vector3(23.380174553944215f,5.083451578267886f,0.0f), new Vector3(23.442003588216117f,5.055536613274556f,0.0f), new Vector3(23.50471153015105f,5.033782363535999f,0.0f), new Vector3(23.568239483842408f,5.01778709786247f,0.0f), new Vector3(23.632523358179796f,5.00712971132003f,0.0f), new Vector3(23.69749373368659f,5.001374322216119f,0.0f), new Vector3(23.76307575875848f,5.000075199731349f,0.0f), new Vector3(23.829189082961836f,5.002781877032936f,0.0f), new Vector3(23.895747835570315f,5.009044315017159f,0.0f), new Vector3(23.96266065797954f,5.018417997817967f,0.0f), new Vector3(24.029830799019543f,5.030468860489983f,0.0f), new Vector3(24.097156282456012f,5.044777969570348f,0.0f), new Vector3(24.16453015610492f,5.060945896677708f,0.0f), new Vector3(24.231840831947814f,5.0785967425831435f,0.0f), new Vector3(24.298981412202956f,5.095170867110461f,0.0f), new Vector3(24.365850022599137f,5.109801660810406f,0.0f), new Vector3(24.432350054817235f,5.121802554739223f,0.0f), new Vector3(24.49839032754851f,5.130659447829647f,0.0f), new Vector3(24.56388517564296f,5.136022966508415f,0.0f), new Vector3(24.628754476675983f,5.137701296557231f,0.0f), new Vector3(24.692923623979716f,5.135654090148099f,0.0f), new Vector3(24.756323454796487f,5.129987757963118f,0.0f), new Vector3(24.818890141742422f,5.120952297486479f,0.0f), new Vector3(24.88056505524305f,5.108939671475578f,0.0f), new Vector3(24.941294604039907f,5.0944836223162655f,0.0f), new Vector3(25.001030060285036f,5.07826067631069f,0.0f), new Vector3(25.05972737515323f,5.061091946778435f,0.0f), new Vector3(25.11734699032119f,5.043945179458556f,0.0f), new Vector3(25.173853650097758f,5.027936296976883f,0.0f), new Vector3(25.22921621844641f,5.01432949865064f,0.0f), new Vector3(25.283407504625043f,5.004534777617829f,0.0f), new Vector3(25.33640410068131f,5.000101565173523f,0.0f), new Vector3(25.388186233585675f,5.002707155803563f,0.0f), new Vector3(25.441199098621578f,5.013363606970341f,0.0f), new Vector3(25.492968354676783f,5.032613930871481f,0.0f), new Vector3(25.54599079580835f,5.060985756706831f,0.0f), new Vector3(25.60027276695129f,5.098981662494203f,0.0f), new Vector3(25.655817428774917f,5.147069759095775f,0.0f)};
frame[] frames = { new frame0(), new frame1(), new frame2(), new frame3(), new frame4(), new frame5(), new frame6(), new frame7(), new frame8(), new frame9(), new frame10(), new frame11(), new frame12(), new frame13(), new frame14(), new frame15(), new frame16(), new frame17(), new frame18(), new frame19(), new frame20(), new frame21(), new frame22(), new frame23(), new frame24(), new frame25(), new frame26(), new frame27(), new frame28(), new frame29(), new frame30(), new frame31(), new frame32(), new frame33(), new frame34(), new frame35(), new frame36(), new frame37(), new frame38(), new frame39(), new frame40(), new frame41(), new frame42(), new frame43(), new frame44(), new frame45(), new frame46(), new frame47(), new frame48(), new frame49(), new frame50(), new frame51(), new frame52(), new frame53(), new frame54(), new frame55(), new frame56(), new frame57(), new frame58(), new frame59(), new frame60(), new frame61(), new frame62(), new frame63(), new frame64(), new frame65(), new frame66(), new frame67(), new frame68(), new frame69(), new frame70(), new frame71(), new frame72(), new frame73(), new frame74(), new frame75(), new frame76(), new frame77(), new frame78(), new frame79(), new frame80(), new frame81(), new frame82(), new frame83(), new frame84(), new frame85(), new frame86(), new frame87(), new frame88(), new frame89(), new frame90(), new frame91(), new frame92(), new frame93(), new frame94(), new frame95(), new frame96(), new frame97(), new frame98(), new frame99(), new frame100(), new frame101(), new frame102(), new frame103(), new frame104(), new frame105(), new frame106(), new frame107(), new frame108(), new frame109(), new frame110(), new frame111(), new frame112(), new frame113(), new frame114(), new frame115(), new frame116(), new frame117(), new frame118(), new frame119(), new frame120(), new frame121(), new frame122(), new frame123(), new frame124(), new frame125(), new frame126(), new frame127(), new frame128(), new frame129(), new frame130(), new frame131(), new frame132(), new frame133(), new frame134(), new frame135(), new frame136(), new frame137(), new frame138(), new frame139(), new frame140(), new frame141(), new frame142(), new frame143(), new frame144(), new frame145(), new frame146(), new frame147(), new frame148(), new frame149(), new frame150(), new frame151(), new frame152(), new frame153(), new frame154(), new frame155(), new frame156(), new frame157(), new frame158(), new frame159(), new frame160(), new frame161(), new frame162(), new frame163(), new frame164(), new frame165(), new frame166(), new frame167(), new frame168(), new frame169(), new frame170(), new frame171(), new frame172(), new frame173(), new frame174(), new frame175(), new frame176(), new frame177(), new frame178(), new frame179(), new frame180(), new frame181(), new frame182(), new frame183(), new frame184(), new frame185(), new frame186(), new frame187(), new frame188(), new frame189(), new frame190(), new frame191(), new frame192(), new frame193(), new frame194(), new frame195(), new frame196(), new frame197(), new frame198(), new frame199(), new frame200(), new frame201(), new frame202(), new frame203(), new frame204(), new frame205(), new frame206(), new frame207(), new frame208(), new frame209(), new frame210(), new frame211(), new frame212(), new frame213(), new frame214(), new frame215(), new frame216(), new frame217(), new frame218(), new frame219(), new frame220(), new frame221(), new frame222(), new frame223(), new frame224(), new frame225(), new frame226(), new frame227(), new frame228(), new frame229(), new frame230(), new frame231(), new frame232(), new frame233(), new frame234(), new frame235(), new frame236(), new frame237(), new frame238(), new frame239(), new frame240(), new frame241(), new frame242(), new frame243(), new frame244(), new frame245(), new frame246(), new frame247(), new frame248(), new frame249(), new frame250(), new frame251(), new frame252(), new frame253(), new frame254(), new frame255(), new frame256(), new frame257(), new frame258(), new frame259(), new frame260(), new frame261(), new frame262(), new frame263(), new frame264(), new frame265(), new frame266(), new frame267(), new frame268(), new frame269(), new frame270(), new frame271(), new frame272(), new frame273(), new frame274(), new frame275(), new frame276(), new frame277(), new frame278(), new frame279(), new frame280(), new frame281(), new frame282(), new frame283(), new frame284(), new frame285(), new frame286(), new frame287(), new frame288(), new frame289(), new frame290(), new frame291(), new frame292(), new frame293(), new frame294(), new frame295(), new frame296(), new frame297(), new frame298(), new frame299(), new frame300(), new frame301(), new frame302(), new frame303(), new frame304(), new frame305(), new frame306(), new frame307(), new frame308(), new frame309(), new frame310(), new frame311(), new frame312(), new frame313(), new frame314(), new frame315(), new frame316(), new frame317(), new frame318(), new frame319(), new frame320(), new frame321(), new frame322(), new frame323(), new frame324(), new frame325(), new frame326(), new frame327(), new frame328(), new frame329(), new frame330(), new frame331(), new frame332(), new frame333(), new frame334(), new frame335(), new frame336(), new frame337(), new frame338(), new frame339(), new frame340(), new frame341(), new frame342(), new frame343(), new frame344(), new frame345(), new frame346(), new frame347(), new frame348(), new frame349(), new frame350(), new frame351(), new frame352(), new frame353(), new frame354(), new frame355(), new frame356(), new frame357(), new frame358(), new frame359(), new frame360(), new frame361(), new frame362(), new frame363(), new frame364(), new frame365(), new frame366(), new frame367(), new frame368(), new frame369(), new frame370(), new frame371(), new frame372(), new frame373(), new frame374(), new frame375(), new frame376(), new frame377(), new frame378(), new frame379(), new frame380(), new frame381(), new frame382(), new frame383(), new frame384(), new frame385(), new frame386(), new frame387(), new frame388(), new frame389(), new frame390(), new frame391(), new frame392(), new frame393(), new frame394(), new frame395(), new frame396(), new frame397(), new frame398(), new frame399(), new frame400(), new frame401(), new frame402(), new frame403(), new frame404(), new frame405(), new frame406(), new frame407(), new frame408(), new frame409(), new frame410(), new frame411(), new frame412(), new frame413(), new frame414(), new frame415(), new frame416(), new frame417(), new frame418(), new frame419(), new frame420(), new frame421(), new frame422(), new frame423(), new frame424(), new frame425(), new frame426(), new frame427(), new frame428(), new frame429(), new frame430(), new frame431(), new frame432(), new frame433(), new frame434(), new frame435(), new frame436(), new frame437(), new frame438(), new frame439(), new frame440(), new frame441(), new frame442(), new frame443(), new frame444(), new frame445(), new frame446(), new frame447(), new frame448(), new frame449(), new frame450(), new frame451(), new frame452(), new frame453(), new frame454(), new frame455(), new frame456(), new frame457(), new frame458(), new frame459(), new frame460(), new frame461(), new frame462(), new frame463(), new frame464(), new frame465(), new frame466(), new frame467(), new frame468(), new frame469(), new frame470(), new frame471(), new frame472(), new frame473(), new frame474(), new frame475(), new frame476(), new frame477(), new frame478(), new frame479(), new frame480(), new frame481(), new frame482(), new frame483(), new frame484(), new frame485(), new frame486(), new frame487(), new frame488(), new frame489(), new frame490(), new frame491(), new frame492(), new frame493(), new frame494(), new frame495(), new frame496(), new frame497(), new frame498(), new frame499(), new frame500()};
void Start()
{
leftskate = (GameObject) Resources.Load("leftskate");
rightskate = (GameObject) Resources.Load("rightskate");
forceline = (GameObject) Resources.Load("ForceLine");
moveline = (GameObject) Resources.Load("MoveLine");
}
void Update()
{
if (Input.GetKey(KeyCode.R))
{
Destroy(skate0);
Destroy(forceline0);
Destroy(moveline0);
Destroy(skate1);
Destroy(forceline1);
Destroy(moveline1);
frameCount = 0;
}
if (frameCount < 501)
{
transform.position = camerapos[frameCount];
frames[frameCount].visualize();
frameCount++;
}
}
}
