/** @jsxImportSource jsx-dom */
import {Texts} from "@/ServerTypes/Texts";
import {useState} from "react";

export function AccountPanelTitle() {

    const [addText, setAddText] = useState("");

    return (
        <h2 className="text-center p-4">
            {Texts.Forms.SiteTitle} {addText}
        </h2>
    );

}
