class GDPR {

    constructor() {
        this.showStatus();
        this.showContent();
        this.bindEvents();

        if (this.cookieStatus() !== 'accept' && this.cookieStatus() !== 'reject') this.showGDPR();

    }

    bindEvents() {
        let buttonAccept = document.querySelector('.gdpr-consent__button--accept');
        buttonAccept.addEventListener('click', () => {
            this.cookieStatus('accept');
            this.showStatus();
            this.showContent();
            //this.saveDateTime();
            this.hideGDPR();
        });

//student uitwerking

        let buttonReject = document.querySelector('.gdpr-consent__button--reject');
        buttonReject.addEventListener('click', () => {
            this.cookieStatus('reject');
            this.showStatus();
            this.showContent();
            //this.saveDateTime();

            this.hideGDPR();
        });

    }

    showContent() {
        this.resetContent();
        const status = this.cookieStatus() == null ? 'not-chosen' : this.cookieStatus();
        const element = document.querySelector(`.content-gdpr-${status}`);
        element.classList.add('show');

    }

    resetContent(){
        const classes = [
            '.content-gdpr-accept',

//student uitwerking
            '.content-gdpr-reject',
            '.content-gdpr-not-chosen'];

        for(const c of classes){
            document.querySelector(c).classList.add('hide');
            document.querySelector(c).classList.remove('show');
        }
    }

    showStatus() {
        document.getElementById('content-gpdr-consent-status').innerHTML =
            this.cookieStatus() == null ? 'Niet gekozen' : this.cookieStatus();
    }

    cookieStatus(status) {

        if (status) localStorage.setItem('gdpr-consent-choice', status);
        if (status) this.saveDateTime();
//student uitwerking

        return localStorage.getItem('gdpr-consent-choice');
    }

//student uitwerking

    saveDateTime() {
        let today = new Date()
        var currentTime = today.getHours() + ":" + today.getMinutes() + ":" + today.getSeconds();
        var currentDate = today.getDate() + "-" + (today.getMonth()+1) + "-" + today.getFullYear();
        let cookieObject = { date: currentDate, time: currentTime };
        localStorage.setItem("dateTime", JSON.stringify(cookieObject));
    }


    hideGDPR(){
        document.querySelector(`.gdpr-consent`).classList.add('hide');
        document.querySelector(`.gdpr-consent`).classList.remove('show');
    }

    showGDPR(){
        document.querySelector(`.gdpr-consent`).classList.add('show');
    }

}

const gdpr = new GDPR();

