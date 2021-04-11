

$(function () {
    $('.alert').alert();

        // a tagimizde bulunan .view classımıza click olduğunda
        $("body").on("click", ".btnModalOpen", function () {
            var url = $(this).data("target");
            //bu urlimizi post et
            $.get(url, function (data) { })
                //eğer işlemimiz başarılı bir şekilde gerçekleşirse
                .done(function (data) {
                    //gelen datayı .modal-body mizin içerise html olarak ekle
                    $("#generalModal .modal-content").html(data);
                    //sonra da modalimizi göster
                    window.$('#generalModal').modal("show");
                })
                //eğer işlem başarısız olursa
                .fail(function (err) {
                    console.log(err);
                    //modalımızın bodysine Error! yaz
                    $("#generalModal .modal-content").text("Error!!");
                    //sonra da modalimizi göster
                    $("#generalModal").modal("show");
                })

        });
    })
