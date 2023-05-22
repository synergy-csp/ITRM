export default class RequestEdit extends Form.Designer {


    async RequestorDepartment_OnLoad(args: Controls.EventArgs.ILoadEventArgs) {
        if (this.RequestorDepartment.value == null) {
            this.RequestorDepartment.value = [this.session.User.Department.Id];
            this.RequestorDepartment.text = this.session.User.Department.Name;
            await this.applyChanges();
        }
    }

    async OpenType_OnValueChanged(args: Controls.EventArgs.IPropertyChangedEventArgs<any>) {
        switch (args.newValue) {
            case "1":
                this.Requestor.clientVisible = true;
                this.RequestorLook.clientVisible = false;
                this.RequestorLook.value = null;
                this.RequestorLook.text = "";
                break;
            case "2":
                this.RequestorLook.clientVisible = true;
                this.Requestor.clientVisible = false;
                break;
            default:
                break;
        }
    }

    async RequestEdit_OnLoad(args: Controls.EventArgs.ILoadEventArgs) {
        if (this.activeView == "developerUser") {
            await this.makeAllReadOnly();
            this.DeveloperDescription.readOnly = false;
        }
        else if (this.activeView == "reviewerUser") {
            await this.makeAllReadOnly();
            this.ReviewReason.readOnly = false;
        }
        if (this.OpenType.value == "2") {
            this.RequestorLook.clientVisible = true;
            this.Requestor.clientVisible = false;
        }
    }

    async makeAllReadOnly() {
        for (const item of this.controls) {
            this[item.name].readOnly = true;
        }
        this.readOnly = false;
    }
}