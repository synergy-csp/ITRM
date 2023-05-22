export default class RequestTypes extends Form.Designer {


    async RequestTypes_Grid_OnActionButtonClick(args: Controls.EventArgs.IActionButtonClickEventArgs) {
        if (args.name == "Delete") {
            await this.showConfirm("Talep Tipi", "Silme işlemini gerçekleştirmek istediğinizden emin misiniz?").then(() => {
                this.fetch.post("DataSource/DeleteRequestType", { "documentId": args.row.find(x => x.name == "DOCUMENTID").value }).then(() => {
                    this.showToaster("Talep Tipi", "Silme işlemi başarıyla gerçekleştirildi.", "Success");
                    this.RequestTypes_Grid.reload(true);
                }).catch((err) => {
                    this.showToaster("Talep Tipi", `Silme işleminde hata oluştu: ${err}`, "Error");
                });
            }).catch((err) => {
                this.showToaster("Talep Tipi", "Silme işlemi iptal edildi.", "Info");
            });
        }
    }
   
	async RequestTypes_OnMessageReceived(args: Controls.EventArgs.IMessageReceivedEventArgs) {
        this.RequestTypes_Grid.reload(true);
	}
}