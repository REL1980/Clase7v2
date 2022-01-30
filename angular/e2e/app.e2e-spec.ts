import { Clase7v2TemplatePage } from './app.po';

describe('Clase7v2 App', function() {
  let page: Clase7v2TemplatePage;

  beforeEach(() => {
    page = new Clase7v2TemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
