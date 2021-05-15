using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using Lab_06_07_OOP.UI;

namespace Lab_06_07_OOP.ViewModel
{
    public partial class ViewModel
    {
        private ObservableCollection<comment> _commentsPrivate = MainWindow.Market.comments.Local;
        private ObservableCollection<comment> _comments;
        private ViewModelCommands _foundComments;
        private ViewModelCommands _addComments;
        private comment _selectComment;
        private Visibility _showComments = Visibility.Hidden;

        public comment SelectComment
        {
            get => _selectComment;
            set
            {
                _selectComment = value;
                OnPropertyChanged("SelectComment");
            }
        }
        public Visibility ShowComments
        {
            get => _showComments;
            set
            {
                _showComments = value;
                OnPropertyChanged("ShowComments");
            }
        }
        public ObservableCollection<comment> Comments
        {
            get => _comments;
            set
            {
                _comments = value;
                OnPropertyChanged("Comments");
            }
        }
        
        public ViewModelCommands FoundComments
        {
            get
            {
                return _foundComments ??
                       (_foundComments = new ViewModelCommands(obj =>
                       {
                           if(SelectedProduct!=null)
                               Comments = new ObservableCollection<comment>(MainWindow.Market.comments.Local.Where(comment =>
                                   comment.CommentProductID == SelectedProduct.ProductID));
                           foreach (var comment in Comments)
                           {
                               comment.CommentUser = MainWindow.Market.users
                                   .Where(p => p.UserID == comment.CommentUserID).First().UserEmail;
                           }
                           if (_showComments == Visibility.Hidden)
                               ShowComments = Visibility.Visible;
                          
                       }));
            }
        }
        public ViewModelCommands CommentAdd
        {
            get
            {
                return _addComments ??
                       (_addComments = new ViewModelCommands(obj =>
                       {
                           if (!MainWindow.Entered)
                           {
                               MessageBox.Show("Оставлять комментарии, могут только зарегистрированные пользователи");
                               return;
                           }
                           if(SelectComment!=null)
                           if(SelectComment.Comment1==null)
                           {
                               MessageBox.Show("Сообщение не может быть пустым");
                               return;
                           }
                           if(SelectComment!=null)
                           if (SelectComment.Comment1 != null)
                           {
                               _commentsPrivate.Add(SelectComment);
                               FoundComments.Execute("");
                               SizeBoxComment = 0.0;
                               SelectComment = null;
                               return;
                           }
                           comment comment = new comment();
                           comment.CommentProductID = SelectedProduct.ProductID;
                           comment.CommentUserID = UserID;
                           SelectComment = comment;
                           ShowCommentPanel();
                       }));
            }
        }
    }
}
