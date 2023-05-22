import * as Controls from "@bimser/form-controls/dist/environments/runtime";
import "./ReviewerSelect.css";

export class Designer extends Controls.Form {
    // properties
    ReviewReason: Controls.TextArea;
Reviewer: Controls.Lookup;

}

export class BSC extends Controls.BuiltIn.BSC {
    // properties
    ReviewReason: Controls.TextArea;
Reviewer: Controls.Lookup;

}

export class BPM extends Controls.BuiltIn.BPM {
    // properties
    ReviewReason: Controls.TextArea;
Reviewer: Controls.Lookup;

}

export class SYNERGY extends Controls.BuiltIn.SYNERGY {
    // properties
    ReviewReason: Controls.TextArea;
Reviewer: Controls.Lookup;

}