/**
 * repare.ts
 */

// @ts-ignore
// @ts-nocheck
import { qrcode } from "https://deno.land/x/qrcode/mod.ts";
import { encodeUrl } from "https://deno.land/x/encodeurl/mod.ts";
import { escapeHtml } from "https://deno.land/x/escape_html/mod.ts";

const semacode_field: HTMLInputElement | null  = document.getElementById("semacode_covid");;
semacode_field.addEventListener("keyup", onChange);
function onChange(event: any) {
    var semacode_data : string = semacode_field.value.trim();

    semacode_data = semacode_data.replace(/(\r\n|\n|\r)/gm, "");
    semacode_data = escapeHtml(encodeUrl(semacode_data));
    semacode_data = semacode_data.replace("\u001D", "%1D");
    semacode_data = semacode_data.replace("\u001F", "%1F");
    console.log("semacode_data");
    console.log(semacode_data);
    var qrcode_final: string = "https://bonjour.tousanticovid.gouv.fr/app/wallet?v="+semacode_data
    qrcode(qrcode_final, { size: 400 }).then((base64image: any) => {
        console.log(base64image);
        const value: string = base64image as unknown as string;
        var qrcode_covid = <HTMLInputElement>document.getElementById("qrcode_covid")
        console.log(base64image);

        qrcode_covid.setAttribute('src', value)
    });
}



