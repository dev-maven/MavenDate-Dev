export interface Message{
    id: number;
    senderId: number;
    senderKnownAs: string;
    senderPhotoUrl: string;
    recipentId: number;
    recipentKnownAs: string;
    recipentPhotoUrl: string;
    content: string;
    isRead: boolean;
    dateRead: Date;
    messageSent: Date;
}