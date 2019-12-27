/* Using an applet context, getCodeBase(),
and showDocument() to display an HTML file.
*/
import java.awt.*;
import java.applet.*;
import java.net.*;
/*
<applet code="ACDemo.class" width=300 height=50>
</applet>
*/
public class ACDemo extends Applet{
public void start() {
AppletContext ac = getAppletContext();
//URL url = getCodeBase(); // get url of this applet
try {
ac.showDocument(new URL("file:///F:/javapro/Applets/Sample.html"),"_self");
} catch(MalformedURLException e) {
showStatus("URL not found");
}
}
}