using BuilderPattern;
using BuilderPattern.Enum;

GiftCardBuilder giftCardBuilder = new GiftCardBuilder();
giftCardBuilder.AddColor(Color.White);
GiftCard card = giftCardBuilder.GetAllGiftCardItems();

