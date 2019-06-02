$( function () {
	"use strict";

	Morris.Bar( {
        element: 'chart-bairros',
		data: [ {
                diaSemana: 'Segunda',
				tatuape: 0,
				morumbi: 0,
				santana: 90,
				lapa: 0,
				outros: 0
        }, {
                diaSemana: 'Terça',
                tatuape: 10,
                morumbi: 60,
                santana: 40,
                lapa: 80,
                outros: 120
        }, {
                diaSemana: 'Quarfa',
                tatuape: 120,
                morumbi: 10,
                santana: 90,
                lapa: 30,
                outros: 50
        }, {
                diaSemana: 'Quinta',
                tatuape: 0,
                morumbi: 0,
                santana: 120,
                lapa: 0,
                outros: 0
        }, {
                diaSemana: 'Sexta',
                tatuape: 0,
                morumbi: 0,
                santana: 0,
                lapa: 150,
                outros: 0
        }, {
                diaSemana: 'Sabado',
                tatuape: 160,
                morumbi: 75,
                santana: 30,
                lapa: 60,
                outros: 90
        }, {
                diaSemana: 'Domingo',
                tatuape: 10,
                morumbi: 120,
                santana: 40,
                lapa: 60,
                outros: 30
        }


        ],
		colors: [ '#26DAD2', '#fc6180', '#62d1f3', '#ffb64d', '#4680ff' ],
        xkey: 'diaSemana',
        ykeys: ['tatuape', 'morumbi', 'santana', 'lapa', 'outros' ],
        labels: ['Tatuape', 'Morumbi', 'Santana', 'Lapa', 'Outros' ],
		pointSize: 0,
		lineWidth: 0,
		resize: true,
		fillOpacity: 0.8,
		behaveLikeLine: true,
		gridLineColor: '#e0e0e0',
		hideHover: 'auto'
	} );

    Morris.Donut({
        element: 'donut_chart_1',
        data: [
            { label: 'Masculino', value: 60 },
            { label: 'Feminino', value: 32 },
            { label: 'Outros', value: 8 },
        ],
        colors: [
            '#26DAD2', '#fc6180', '#ffb64d'
        ],
        formatter: function (y) { return y + "%" }
    });

} );
