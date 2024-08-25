window.generatePdf = (htmlContent) => {
    return new Promise((resolve, reject) => {
        const { jsPDF } = window.jspdf;
        const doc = new jsPDF();

        doc.html(htmlContent, {
            callback: function (doc) {
                const pdfBlob = doc.output('blob');
                const reader = new FileReader();
                reader.onload = function () {
                    const arrayBuffer = reader.result;
                    const byteArray = new Uint8Array(arrayBuffer);
                    resolve(byteArray);
                };
                reader.readAsArrayBuffer(pdfBlob);
            },
            x: 10,
            y: 10
        });
    });
};
